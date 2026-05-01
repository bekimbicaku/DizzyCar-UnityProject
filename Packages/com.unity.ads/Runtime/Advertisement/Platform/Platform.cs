using System;
using System.Collections.Generic;
using UnityEngine.Advertisements.Events;
using UnityEngine.Advertisements.Utilities;

namespace UnityEngine.Advertisements.Platform
{
    internal class Platform : IPlatform
    {
        public IBanner Banner { get; }
        public IUnityLifecycleManager UnityLifecycleManager { get; }
        public INativePlatform NativePlatform { get; }

        public bool IsInitialized => NativePlatform?.IsInitialized() ?? false;
        public bool IsShowing { get; private set; }
        public string Version => NativePlatform?.GetVersion() ?? "UnknownVersion";
        private readonly Dictionary<string, string> placementToObjectId = new();
        public bool DebugMode
        {
            get => NativePlatform?.GetDebugMode() ?? false;
            set => NativePlatform?.SetDebugMode(value);
        }

        public Platform(INativePlatform nativePlatform, IBanner banner, IUnityLifecycleManager unityLifecycleManager)
        {
            NativePlatform = nativePlatform;
            Banner = banner;
            UnityLifecycleManager = unityLifecycleManager;
            NativePlatform.SetupPlatform(this);
        }

        public void Initialize(string gameId, bool testMode, IUnityAdsInitializationListener initializationListener)
        {
            if (!IsInitialized)
            {
                var framework = new MetaData("framework");
                framework.Set("name", "Unity");
                framework.Set("version", Application.unityVersion);
                SetMetaData(framework);

                var adapter = new MetaData("adapter");
#if ASSET_STORE
                adapter.Set("name", "AssetStore");
#else
                adapter.Set("name", "Packman");
#endif
                adapter.Set("version", Version);
                SetMetaData(adapter);
                NativePlatform.Initialize(gameId, testMode, initializationListener);
            }
        }

        public void Load(string placementId, IUnityAdsLoadListener loadListener)
        {
            if (string.IsNullOrEmpty(placementId))
            {
                Debug.LogError("placementId cannot be nil or empty");
                return;
            }
            LoadOptions loadOptions = new LoadOptions();
            if (!string.IsNullOrEmpty(placementId))
            {
                string objectId = Guid.NewGuid().ToString();
                placementToObjectId[placementId] = objectId;
                loadOptions.ObjectId = objectId;
            }
            NativePlatform.Load(placementId, loadOptions, loadListener);
        }

        public void Show(string placementId, ShowOptions showOptions, IUnityAdsShowListener showListener)
        {
            if (IsShowing) return;

            if (showOptions != null && !string.IsNullOrEmpty(showOptions.gamerSid))
            {
                var player = new MetaData("player");
                player.Set("server_id", showOptions.gamerSid);
                SetMetaData(player);
            }
            var objectId = "";
            if (!string.IsNullOrEmpty(placementId) && placementToObjectId.ContainsKey(placementId))
            {
                objectId = placementToObjectId[placementId];
            }
            NativePlatform.Show(string.IsNullOrEmpty(placementId) ? null : placementId, objectId, showListener);
        }

        public void SetMetaData(MetaData metaData)
        {
            NativePlatform.SetMetaData(metaData);
        }

        public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
        {
            IsShowing = false;
        }

        public void OnUnityAdsShowStart(string placementId)
        {
            IsShowing = true;
        }

        public void OnUnityAdsShowClick(string placementId)
        {
        }

        public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState completionState)
        {
            IsShowing = false;
        }

    }
}
