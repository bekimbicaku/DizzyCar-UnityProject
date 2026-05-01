# Changelog
## [4.16.4] - 2025-11-18
Fixed an issue that might prevent banners from refreshing correctly in projects using Unity Editor 6.0 or newer

## [4.16.3] - 2025-10-09
### **Android**
Optimized fallback logic when issues are detected during initialization.
### **iOS**
No change.

## [4.16.2] - 2025-10-02
### **Android**
Updated banner API to improve compatibility with mediation partners for smoother banner integration.
Updated in-app purchase support for Google Play Billing Library v8 to ensure smoother transactions.
### **iOS**
Enabled offerwall ads for apps that already integrate an offerwall SDK.


## [4.16.1] - 2025-08-06
### **Android**
Reduced Unity Ads SDK initialization time.
### **iOS**
Reduced Unity Ads SDK initialization time.


## [4.16.0] - 2025-07-23
### **Android**
Improved handling to ensure ads can display correctly after the app screen closes.
Added feature to enable Android publishers to promote offerwalls with Unity Ads.
### **iOS**
Upgraded the minimum Target iOS version to 13.


## [4.15.1] - 2025-07-02
### **Android**
Fixed an ad lifecycle issue potentially denying the display of subsequent ads in a session.
Updated the Proguard consumer file for improved Acquire Optimizations support.
### **iOS**
No change.

## [4.15.0] - 2025-05-28
### **Android**
Added support for the Android display content edge-to-edge feature.
Added a new getToken API that supports ad formats. Providing an ad format optimizes ad loading processes for faster ad delivery.
Improved asset memory usage.
Improved error handling.
Fixed issue with streaming ad performance on low-end devices.
### **iOS**
Added a new getToken API that supports ad formats. Providing an ad format optimizes ad loading processes for faster ad delivery.
Refined Show error message to improve consistency across mediation error messaging.
Improved asset memory usage.
Fixed behavior of error message Cannot show the ad while another is already being shown, which appeared when no ads were showing.

## [4.14.2] - 2025-04-16
### **Android**
Refactored and optimized the signal collection system for better performance.
Improved support for some ad network A/B testing scenarios.
### **iOS**
Added a safeguard to prevent an issue affecting acquisition improvement in some iOS apps.
Fixed an issue affecting banner error reporting.

## [4.14.1] - 2025-03-24
### **Android**
Enhanced error reporting for publisher edge cases.
Upgraded Protobuf dependency from v3.21.12 to v3.25.6 to address a known security vulnerability.
### **iOS**
No change.

## [4.14.0] - 2025-03-11
### **Android**
Added the feature to promote an offerwall from within video placements.
### **iOS**
No change.

## [4.13.2] - 2025-02-25
### **Android**
No change.
### **iOS**
Optimized ad impression opportunities in some scenarios.

## [4.13.1] - 2025-01-29
### **Android**
Fixed a crash that could occur when attempting to re-initialize the SDK inside the initialization complete callback.
### **iOS**
Fixed framework warnings related to the UnityAdsCommon.h file in the Unity Ads framework.
Fixed an issue where the initialization callback would not fire when calling initialization multiple times.

## [4.13.0] - 2025-01-14
### **Android**
Fixed a potential Null Pointer Error for Banners.
Fixed a potential deserialization issue in the Android Player.
Improved reporting for initialization failures.
Fixed an issue with operative message event retries following an error message.
Improved data requests to simplify reporting complexity.
### **iOS**
Fixed an issue that could cause a crash when changing the device mute status.
Standardized metric names to simplify reporting complexity.

## [4.12.5] - 2024-11-21
### **iOS**
#### **Feature**

- Add Token Counters
- Send isHeaderBidding in AdContext to Adviewer (#1949)
- Move Gateway Cache Storage to Private Storage (#1946)
#### **Bugfix**

- Store Privacy as base64 vs Data (#1952)
- Store Base64 as Url Safe (#1956)
- Use cache folder for webview and adviewer files (#1958)
### **Android**
#### **Feature**

- Add isHeaderBidding (#1948)
#### **Bugfix**

- Add HB Token Counters (#1939)
- Use WV2 configuration store (ELS) as gateway cache for Bold SDK (#1947)

## [4.12.4] - 2024-10-22
### **iOS**
#### **Feature**

- Add ability to setup for tests using plist
- Add ability to setup for tests using plist
#### **Bugfix**

- AppSheet Screen Freeze Fix
### **Android**
#### **Feature**

- Use FilesDir for storing cached WebView and Native configuration (#1866)
- Add read timeout to CronetClient (#1870)
- Properly close body in OkHttpClient (#1873)
- Refactor AndroidCacheRepository to improve caching (#1885)
#### **Bugfix**

- Update integration tests for GatewayClient (#1851)
- When Google Play Billing is missing, report Diagnostic but dont log error. (#1863)
- Move static injects into functions for UnityAdsSDK.kt to avoid tests keeping references
- Ensure SDK state is set before calling back IUnityAdsInitializationListener listener. (#1878)
- Add extension in when retrieving from file system
- Fix gameId Android fix in AndroidSessionRepository.kt
- Create unityAdsDataStoreFile extension in ContextExtensions.kt
- Use concurrent collections for allowedEvents, blockedEvents and batch list
- Prevent `null` DiagnosticEvents to crash (#1891)

## [4.12.3] - 2024-09-19
### **iOS**
#### **Feature**

- Adding a webview project for iOS Webview CI (#1797)
- Set SDK Version to provided e2e test version
- Return Full, Init or Limited Token
#### **Bugfix**

- Fix callback invocation in WebViewExposed_getSharedSessionID
- Set preferredContentMode to mobile for WKWebViewConfiguration
- Keep self alive in callback stack
- Each Ad Own Measurer
- Add a queue for mute state timer (#1825)
### **Android**
#### **Feature**

- Add optional limited token to HB token
- Update unityapis to main
#### **Bugfix**

- Capture BannerView null on show
- Fix ShowOptions serialization issue
- Use default dispatcher for coroutines
- Fix boldSDK getToken timeout
- Add missing preparation for test (#1824)
- Remove unused file
- When preparing the Gateway Protobuf files, only use /v1 (#1835)
- Update with base branch


## [4.12.2] - 2024-08-02
### **iOS**
#### **Feature**

- UnityAds API in swift
- Fix Legacy Show Timeout Issue
- Add Missing Init Signals
#### **Bugfix**

- Force preferred mode to mobile. Use semaphore instead of infinite run loop wait
- Add is_retry and source tags to Init metrics
- Make Orientation Dynamic Single Truth
- Log outgoing messages correctly
- Add TCFString from UserDefaults to token and request
### **Android**
#### **Feature**

- Add IS Signals for HB Token
#### **Bugfix**

- Fix potential crash when Billing Service disconnects while listening. (#1753)
- Fix Proguard rules to keep Protobuf defined classes. (#1754)
- When the activity is destroy from external sources, still send the event to AdPlayer so he can handle it gracefully. (#1762)
- Show timeout locking SDK into isShowing state
- Change LegacyShowUseCase to factory
- Fix passing of tags into value param
- Add stacktrace to SDKErrorHandler.kt
- Support missing orientation (#1783)

## [4.12.1] - 2024-07-04
### **iOS**
#### **Feature**

- Retriable Init for GetToken and Load
#### **Bugfix**

- Add mediation info to legacy init metric tags
- Add Apple Dependencies to Podspec
- Minor Changes to align further with Legacy
- Set isInitialized when bold init is done
- Send updated session counters with token
### **Android**
#### **Bugfix**

- Fix Cronet cache directory deletion
- Fix AndroidDeveloperConsentDataSource for non boolean values (#1724)
- Fix missing operation id passing for WebView exposed methods in Store API. (#1727)
- Allow reinitialization in BoldSDK
- Fix legacy initialization with no connectivity
### **Unity**
#### **Bugfix**

- Migrate from the obsolete FindObjectOfType to FindAnyObjectByType in sample app. (#1711)

## [4.12.0] - 2024-05-30
### **iOS**
#### **Bugfix**

- Update Version Int in Fastlane
- Release adobject from memory if webview was terminated
- Pass proxy object instead of bridge for request's extra
- Include AdType with operative_event_sent metric
- Pass admarkup for banners in bold sdk flow
- Do not use AUID for IDFI in boldSDK
- On iOS 12 The Sheet Doesnt Dismiss
- Fix UADSGenericMediator crash when timeout happens at the same time as notify
- Pass unique id for getToken measurement
- Main Async from Sync where Applicable
### **Android**
#### **Bugfix**

- Improve InitializationException use
- Include OMID scope to service provider. (#1668)
- Use koin-core-jvm instead of koin-core as we don't want the transitive dependencies. (#1669)
- Don't try to read default native config in case of error. (#1677)
- Update AUID logic
### **Unity**
#### **Feature**

- Make Dependencies a range up to major version
- Map ObjectIds to PlacementIds

## [4.11.3] - 2024-05-10
### **iOS**
#### **Bugfix**

- Fast-fail show if wkwebview terminated, remove strong ref to message sender in appsheet receiver
- Pass error code and message to webview
### **Android**
#### **Bugfix**

- Fix potential race condition causing NPE in AndroidSessionRepository init block. (#1660)
- Remove all BOM dependencies from Unity Ads SDK. (#1661)


## [4.11.2] - 2024-05-05
### **Android**
#### **Bugfix**

- Use koin-core instead of koin-android to address potential EDM4U resolution issue. (#1655)


## [4.11.1] - 2024-05-05
### **Android**
#### **Bugfix**

- Explicitly include koin-android to our dependencies. (#1653)

## [4.11.0] - 2024-05-03
### **iOS**
#### **Feature**

- Send transaction data to gateway once received
- Deduplicate transactions based on last sent transaction date
- Implement reader for all purchased and valid iap transactions
- Send new transactions once init is done
- Use domain from privacy response for config request
- Set adsGateway flag at Init
- ProductInfoReader with StoreKit2
- canMakePayments for adviewer
- canMakePayments to adRequest
- Add trackingAuthStatus to init request
- Add support for limitedSessionToken
- Include OMSDK into the projects
- Use boldSdkNextSessionEnabled to turn on/off gateway flow
- Wait for init complete for async getToken
- Provide LoadOptions and ShowOptions to AdViewer
#### **Bugfix**

- Allow Webview to Subscribe to Notifications
- Fix version reading for Admob 11
- Replace deprecated openURL method
- Fix Xcodegen update XCPrivacy issue
- Update PrivacyRequestData
- Fix memory leak when webview does not respond with load completed/failed
- AdViewer Sends Bool not Dictionary
- Call finish session in time before banner destroyed
- Adding load_cache metric event decorator
### **Android**
#### **Feature**

- Integrate IAP transactions with Gateway flow. (#1416)
- DI improvement (#1573)
- Control Bold SDK flow via experiment flag. (#1612)
- Set Gateway Cache to BoldSdkNextSessionEnabled version value. (#1618)
- Await for init for getToken
- Cleanup LegacyLoadUseCase.kt
- Provide loadOptions and showOptions to AdViewer. (#1630)
#### **Bugfix**

- Fix Scope threads (#1586)
- Fix ExposedFunctions
- Fix possible null @NonNull loadOptions
- Fix sendUpdatePrivacyRequest API discrepancy (#1609)
- Ensure unknown BillingResultResponseCode doesn't return null. (#1608)
- Lower log level when trying to fetch wrong fix of SharedPreferences (#1619)
- Prevent crash when native bridge throws OOM exception. (#1626)
- Prevent crash when no HTTP response headers are provided in WebRequest. (#1627)
- Correctly finish OMID sessions for banners
- Fix removal of LoadOptions when providing AdContext. (#1647)
- Fix getToken async race condition
### **Unity**
#### **Feature**

- Remove static libraries and use MDR. (#1639)
#### **Bugfix**

- Fix AdContext structure for OM
- Fix AdContext structure for OM properly

## [4.10.0] - 2024-03-25
### **iOS**
#### **Feature**

- Assets Download Queue
- Download Api Receiver
- Add toggle to fetch adm when loading
- Bump xcode version to 15.1 (#1518)
- Manifest needs to be part of target
- Flag adsGateway Update to V2
### **Bugfix**

- Prevent crash when timeout happens at the same time as notify
- Use TARGET_OS_SIMULATOR for isSimulator check
- Change retriable operation to class and handle memory management in withRetry decorators
- Do not retry metrics on gateway error
- Prefix Free isCached Check
### **Android**
#### **Feature**

- Committing files involved in merge conflict
- Create OM ad session
- Create AndroidCacheRepository
- Expose download Cache API
- Add support for `leftApplication` (#1535)
- Persist testing sessions (#1521)
- Support for banner in Bold SDK (#1525)
- Fix native caching and clear cache on init
- Adjust OM Js file serving
- Add support for GMA SDK v23. (#1568)
#### **Bugfix**

- Fix metric namings
- Fix invocation handling coroutine scope usage. (#1510)
- Banner loaded callback triggered twice (#1514)
- Fix ServiceProvider.kt
- Persist appStoreId in Test App for HeaderBidding request. (#1547)
- Use default `objectId` for banners with Gateway (#1550)
- Correct Cache path naming (#1564)


## [4.9.3] - 2024-02-21
### **iOS**
#### **Feature**

- Local Podspec For UAds
- Add SKOverlay support for adviewer
- Move Example App to new Public Folder
- Rename Task to AsyncTask
- Sanitize AppSheet Nonce
- Load WebView Queue
- Add metrics condition to flush based on metric name
- Add QUIC hints for CDN
#### **Bugfix**

- Moving TestApp up one Folder
- NonBehavioural fix
- Rebuild Swift Proto FW if empty
- Remove aiff sound file
- Avoid Setting gateway flag on Any Commit
- Fix China Url Issue
- Reset id when Manually Dismissing
- Remove prefix for web_view passed metrics
- Notify webview when SKProductViewController fails presenting
- Metrics Failure Race Condition
- Set Request Timeout
### **Android**
#### **Feature**

- Have one CoroutineScope per public API function. (#1319)
- Align EmbeddableAdPlayer with generic AdPlayer (#1330)
- Download static assets (#1331)
- Add support for SonarQube (#1334)
- Use HeaderBiddingAdMarkup
- Generate Header Bidding Token
- Internal Test App - Base (#1403)
- Add Header Bidding get adm support for legacy (#1409)
- Intercept assets (#1387)
- Create asset loaders for webview and ad assets
- Allow Cronet to download into files
- Allow OkHttp to download into files
- Basic UI for internal test app (#1420)
- Allow HttpRequest to have priorities
- Test App - Override WebView Url (#1439)
- Get static assets on assembleRelease. (#1450)
- Improve WebView crashes handling (#1463)
- Use Gateway HB endpoint (#1483)
#### **Bugfix**

- Fix DeveloperConsent enum value parsing. (#1316)
- Prevent Package Name to be null (#1328)
- Fix when ByteString stored in DataStore is stringified UUID. (#1350)
- Re-enable the button to load an ad when show fails
- Fix ProGuard issues with Android Privacy Sandbox services (#1388)
- Fix diagnostic flushing logic
- Localize UnityAdsImplementation ServiceProvider access
- Banner preventing full screen ads (#1417)
- isDestroy WebView race condition (#1422)
- Send initialization diagnostic on failure (#1430)
- Use CoroutineScope factory for load/show (#1431)
- Dont fail load after load start event but still send diagnostic
- Add HB tag to load metrics
- Align openUrl with iOS (#1440)
- Return null token if not initialized
- Fix value issue from sendDiagnosticEvent to be a Double (#1441)
- Optimize getToken for sync usage
- Handle all public API issues inside BoldSDK
- Capture error from test server (#1457)
- Remove empty privacy blocks
- Send diagnostic event on render process gone. (#1476)
- Correct REASON and REASON_DEBUG tags for HB failures


## [4.9.2] - 2023-11-08
### **iOS**
#### **Feature**

- Add Podfile with swift-protobuf dependency
- Adding ads-protobuf as a submodule
- Generate workspace for UnityAdsCommon
- Generated Swift Proto Files
- Add GatewayRequestFactory for init request
- Network Sender Decorators
- Init task for bold sdk
- Basic interfaces
- Universal request network sender
- Implemented MutableDataProvider in UniversalSessionStorage
- Gateway operative event request adapter
- Gateway type and error check decorator
- Initializer Assebmly
- Add OperativeEvent adapter, changed AdObjectConfig
- BoldSDK OBJC Integration
- Ad Loader Api integration with OBJ
- HeaderBiddingToken adapter and HeaderBiddingTokenReaderBold
- Connect with obj-c
- PersistantStorage for requests, NetworkSenderWithRequestStorage
- Add init state to trigger sending stored operative events
- Use NativeConfiguration's request policies to construct NetworkSenders
- Use jitter from retry poclicies to calculate delay
- Send initCompletedEvent request if needed
- GatewayMetricSender and builder
- Modify init integration tests to check for metrics
- Add network diagnostic reader and sender, modify integration tests
- Timer with lifecycle implementation
- On Mute Subject
- Support Passing Failure to the WebView
- Add load started, success, failure metrics
- Add metrics for show start/click/complete/fail
- Support webview method sendDiagnosticEvent
- Ad Object Context Storage
- Connect AdStorage with RequestBodyAdapter
- Connect Campaign State Management receiver
- Add metrics for load config and downloading webview files
- Refresh Ad Data Request
- Ability to update tracking token
- Add AudioSession Receiver
- Send operative event on load/show error
- Support of First Init Flag
- Add Privacy Payload to Show Options
- Add Session Timestamp into Timestamps
- VidePreload timeout fix
- Implement start/end impression webview exposed methods
- Include SwiftProtobuf as XCFramework
- Provide Proper initial value of Mute state
- Add support for writing to disk on save
- AppStarTime to SDKStartTime renaming
- Add Performance Metrics to AdObjectBuilder
- Expose Delete Key to StorageAPI
- Add error handling on LoadFromURLFailure
- WebView Errors
- Show WebView Fail Integration Test
- Increase minimum supported version to ios 12
- Rename FSM to Fsm
- Example App Multiload Ads
- Improve Load From URL metrics
- fix banner view constraint
- Send Metric Event for Memory Warning
- Add AudioVolume to ShowOptions
- Expose CancelShowTimeout
#### **Bugfix**

- Swap usage of name and topic for Request Message
- Check for initCompleteEvent request in validation
- first pass on protobuf changes
- Orientation Selection Logic
- <subject>
- Fix AppSheetReceiverName
- On Mute Change Only When Change
- Broadcast event payload alignment
- Broadcast payload Fix
- Dont force timers to run on main thread
- Add WillResignActive
- Allow update campaign data for shownCampaigns
- Optional body try call
- Loaded/Shown campaigns should have locked timestamps
- Use Runloop add in Common Mode
- Support Strings to Bool in Storage
- No Fill Handling
- Safely install rbenv and run init command
- First Mute State fix
- Prevent Overriding LoadTimestamp
- Show Client Api on main thread
- Gracefully fail if terminate happens during load or show
- Remove Bold Reference
- Change mac-os to 13`
- Hide UnitySwiftProtobuf Import
### **Android**
#### **Feature**

- Adding ads-protobuf as a submodule
- Protobuf support (#790)
- AdPlayer Module (#791)
- Support banner for AdPlayer (#801)
- Add Device info collection in Kotlin
- Add SessionRepository
- Add AdRepository
- Add WebViewClient error handling (#851)
- Add AndroidGetWebViewContainerUseCase (#852)
- Creating GatewayClient and unit tests
- Add Bold SDK Initialization Flow
- Add Bold SDK Load and Show Flow and update ServiceProvider.kt
- Implement getAdContext for WebView (#872)
- Add support for Operative Events (#880)
- Add DataStore to persist necessary SessionRepository.kt data
- Update show options for AdPlayer (#908)
- Use base64 for impression config (#912)
- Added InitializationCompletedRequest if needed during initialization
- Wait for loadComplete (#919)
- Extracting constant info into constants file and request policy getters
- Add support for Work Manager (#918)
- Support mute event (#927)
- Add openUrl AdViewer api (#932)
- Add Show API to AdPlayer (#938)
- Add loadError to AdPlayer
- Expose Storage API to AdViewer (#965)
- Persist Privacy FSM (#981)
- Notify privacy changes to AdViewer (#986)
- Adding space back, deleting test file
- Expose Privacy Methods (#985)
- Add Cronet as primary network client for BoldSDK (#948)
- Expose canUsePii to AdViewer (#999)
- Adding markCampaignStateAsShown API support
- Add broadcastEvent (#1001)
- Add body/headers to Cronet requests
- Add base for sending diagnostic events
- Add metrics for initialization
- Add updateTrackingToken API to webview exposure
- Expose Request.java on BoldSDK
- Collect GPU info for StaticDeviceInfoDataSource
- Handle Ad Refresh
- Add metrics for load
- Expose sendDiagnosticEvent to AdViewer (#1072)
- Add Show Metrics
- Move gameId to nativeContext (#1080)
- Update session counters (#1078)
- Add isFirstInit flag (#1068)
- Prevent multiple shows
- Add batching logic for metrics
- Add app initialization time to SharedData
- Add optional native timeout for load and show
- Select relevant proto files (#1185)
- Adding AUID to initialization request
- Block further initializations if gateway responds with an error
- Add extensionVersion to AndroidStaticDeviceInfo
- Usecase for SendWebViewClientErrorDiagnostics
- Add diagnostic for cronet build time
- Correctly batch metrics after init
- Add AdViewer API to cancel native show timeout. (#1294)
#### **Bugfix**

- Update staging URL in integration tests (#835)
- Fix SdkErrorHandler to ensure it doesn't throw a NPE (#820)
- Prevent spamming warnings on missing permissions (#857)
- Fix Bold SDk flow after merge
- Add missing cronet dependency (#902)
- Capture load url errors (#923)
- Add missing dependencies in ServiceProvider.kt
- Migrate IDFI to DataStore
- Add legacy support for idfi generation by DataStore
- Correct wrong device info values
- Load now throws an error when no AdObject is created. (#964)
- Add Ad RequestPolicy to ServiceProvider
- Fix AdRefresh parameter handling
- Fix updateCampaignState data's type (#1087)
- Prevent race condition with gameId (#1106)
- Prevent bridge.sendEvent to cancel scope on error (#1102)
- Prevent campaign state from being completely overridden on update (#1125)
- Dont send empty diagnostic events batch
- Increment session counter loadRequest before sending request. (#1172)
- Break flow on initialization failure
- Prevent calls to destroyed WebView. (#1175)
- Handle webview error edge cases
- Provide Build ID correctly instead of Version Name (#1190)
- Convert Request body properly both ByteArray and String as string before passing to AdViewer (#1202)
- Dont filter out events if allowedEvents is empty.
- Omitting show timestamp if campaign has not been shown yet
- Dont let show timeout cancel scope
- Fix INIT_SUCCESS and INIT_FAILURE naming
- Use SendDiagnosticEvent for SDKErrorHandler if boldSDK
- When user calls Load but gateway fails, report onUnityAdsFailedToLoad (#1243)
- Storage API exposed to AdPlayer needs to support all data fixs. (#1244)
- Handle null placement id and listeners correctly. (#1252)
- Fixing sessionTimestamp value
- IDFA and Open Advertising ID sent as 16 bytes array. (#1272)
- Improve logging and diagnostics
- Add missing dynamic device fields
- Fix CronetClient to take in Strings and ByteArray for POST request. (#1278)
- Fixed multiple load when WebView fails to load url. (#1289)
- Move OpenAdvertiserId and AdvertiserId initialization from init block. (#1296)
- Dont send diagnostics for universal request to avoid loop (#1284)
- Switching stream fix to MUSIC
- Prevent crash on getToken when null (#1305)
- Run timeout callbacks on UI thread (#1308)

## [4.9.1] - 2023-10-13
### **Android**
#### **Bugfix**

- Correctly pass down IUnityAdsTokenListener into BiddingManagerFactory


## [4.9.0] - 2023-09-27
### **iOS**
#### **Feature**

- Implement WebViewExposed_getSCARSignal
- Implement webview exposed method LoadScar for banners api
#### **Bugfix**

- Pass value for load success/failure
- Crash Fix Missing Delegate Callback
### **Android**
#### **Feature**

- Add support for Android Privacy Sandbox Measurements and Topics APIs (#934)
- Create new getScarSignal API, add collecting SCAR signal for banners and to HB flow
- Implementing SCAR banner load
- Add experiment to remove native load timeout
- Add experiment to remove native show timer
- Add feature flag around HDR metrics
- Add experiment to control collecting SCAR hb banner signal
- Check for windows Google Play Games on PC
- Expose hardware video decoders to webview
#### **Bugfix**

- Fix Banner Load fail not parsing NO_FILL
- Fix hide banner button in example app
- Rollback Result removal from tasks due to breaking MetricTask success/failure capture
- Prevent AdUnitActivity onDestroy NPE
- Add NPE fix for Android fix in SDKErrorHandler
- Set metrics enabled calculation to occur in Configuration

## [4.8.0] - 2023-06-22
### **iOS**
#### **Feature**

- Add 5g to legacy network feat
- Added bannerViewDidShow delegate method support
#### **Bugfix**

- Add safeguard before setting supported orientations to avoid crash
### **Android**
#### **Feature**

- Adding new unit tests
- Add metric collection on Cronet availability and latency


## [4.7.1] - 2023-05-09
### **iOS**
#### **Bugfix**

- Add safety check for viewId to avoid crash on banner dealloc
### **Android**
#### **Feature**

- Measurements API support (#745)"
- Topics API support (#744)"


## [4.7.1] - 2023-05-08
### **iOS**
#### **Bugfix**

- Add safety check for viewId to avoid crash on banner dealloc
### **Android**
#### **Feature**

- Measurements API support (#745)"
- Topics API support (#744)"


## [4.7.0] - 2023-05-02
### **iOS**
#### **Feature**

- Port ads tracking methods to swift
- Port min device info reader to swift
- Fast fail if the game is disabled
- Add AUID into TRR and Token
#### **Bugfix**

- Version.versionNumber return 4 digit number
- Do not send userNonBehavioral if value wasn't written to the storage
- Non Behavioural flag Gate
### **Android**
#### **Feature**

- Bump to java 8 and bump kotlin dependencies (#641)
- Topics API support (#744)
- Measurements API support (#745)
#### **Bugfix**

- Ensure VolumeChange is thread safe. (#687)
- Add user.nonbehavioral flag to privacy resolution request (#719)
- Fix NPE when receiving null SslError instance. (#740)
- Only send NonBehavioral flag in Native and TRR when Privacy allows it (#742)
- Fix Activity leak from Show Operation (#741)
- Prevent banner error to be triggered more than once (#717)
- Ensures WebView is not null before calling destroy() to avoid potential NPE. (#757)

## [4.6.1] - 2023-03-13
### **iOS**
#### **Bugfix**

- Only set tid in native token if strategy experiment is running
- Xcode 13.4 Support
### **Android**
#### **Bugfix**

- Update BiddingManagerFactory to respect experiment settings with synchronous getToken call and create new unit tests

## [4.5.0] - 2022-12-16
### **iOS**
#### **Feature**

- Add support for adDidRecordClick to SCAR implementation
- Modify SCAR V8.5+ to not store GADQueryInfo and use adStrign
- Add experiment for the new swift flow (#498)
#### **Bugfix**

- Fix conversion for post request from obj-c to swift (#490)
- Add type check for SKAdNetworkItems
### **Android**
#### **Feature**

- Add Kotlin to project
- Setup ServiceProvider.kt
- Setup Dokka for Kotlin javadocs generation
- Add Java-Kotlin bridge
- Adding new module adapter for GMA v21
- Reducing duplicate code in MobileAdsBridgeV20 and V21 classes, adding shouldInitialize function to GMAInitializer
- Adding support for onAdClicked for all ad feats in V21
- Adding extra parameters to SCAR ad requests, removing storage of QueryInfo to load SCAR ads on v21
#### **Bugfix**

- Add try catch for isPlaying() in VideoPlayerView.java
- Fix cleanup legacy path of BaseTimer timer for timeouts
- Fix decoder metrics value


## [4.4.2] - 2023-04-29
### **Unity**
 - Remove redirect pop-ups directing users to Unity Mediation.
### **Android**
#### **Bugfix**
- Fixed a NullPointerException when Application Context is null for cached directory file path.

## [4.4.1] - 2022-10-05
### **iOS**
#### **Feature**

- Generate gmae session id and save to storage
#### **Bugfix**

- Add sdkVersion and sdkVersionName to minimal device reader
- Use Swift through reflection in obj-c
### **Android**
#### **Feature**

- Add experiment to remove required gesture for media playback
- Generate sessionID the same way web view does and save it to unifiedconfig.data
#### **Bugfix**

- Fix ConfigurationReader if no remote nor local file are present. (#432)
- Fix potential crash in some flavour of Android 8.1 where TimeZone API has issues. (#433)
- Remove false error log message when missing applied rule for experiment object (#440)
### **Unity**
#### **Feature**

- removed testmode from services window in versions of unity 2020 and higher
#### **Bugfix**

- added batchmode check to editor dialog popup
- Renamed Arial.ttf to LegacyRuntime.ttf for 2022.2 and above editor playmode support

## [4.4.0] - 2022-09-01
### **iOS**
#### **Performance Improvements**

- Network performance improvements
### **Android**
#### **Bugfix**

- Add tags to new Load/Show metric where missing to avoid being discarded
- Align retry metric tags with iOS
- Move token type into TokenListenerState class
- Invert operation order to test if affecting token latency metric
- Fix BannerPosition being obfuscated by ProGuard
- Fix potential concurrency in Signals Storage when signals are collected in parallel. (#423)
- Revert Proguard rules. (#424)
### **Unity**
#### **Bugfix**

- Fix sample app anchors to work in horizontal
- Update screenorientation API
- mediation migration copy changes

## [4.3.0] - 2022-07-25
### **iOS**
#### **Feature**

- Publishing to Artifactory
- Add support for additional identifiers for SKOverlayAppConfiguration
#### **Bugfix**

- Fix crash related to UADSTimer
- Fixed bug when show failed callback was fired when ad was closed at the start of show
### **Android**
#### **Feature**

- Adjusted Proguard rules for obfuscation (#225)
- Introduce Privacy request before configuration Request (#317)
- Introduce UnityAdsShowError.TIMEOUT when not able to show under specified time frame. (#334)
#### **Bugfix**

- Fix potential NPE when receiving null as purchase list for acquire optimization. (#311)
- Make Load and Show timeouts lifecycle aware
- Add metrics for retries in config and webview
- Fix retry metric tags overriding others instead of merging
- Remove the use of setAppCacheEnabled
### **Unity**
#### **Feature**

- Remove toggle button from project settings ads window
#### **Bugfix**

- Project Settings window fix 2022.1f1


## [4.2.1] - 2022-05-11
### **iOS**
#### **Bugfix**

- Fix crash related to UADSTimer



## [4.2.0] - 2022-05-06
### **Unity (Editor, Asset Store, & Packman)**
#### **Features**
- Add Sample app
#### **Bug Fixes**
- UADSDK-1608 Show Listener now returns appropriate callback state (benlangerak)
- UADSDK-1785 Ensure callbacks are fired on the main thread (benlangerak)

## [4.1.0] - 2022-03-17
### **Unity (Editor, Asset Store, & Packman)**
#### **Bug Fixes**
- Fix IUnityAdsShowCallback makes duplicate calls in Editor PlayMode

## [4.0.1] - 2022-02-02
### **iOS**
#### **Bugfix**
- Fix crash that occurs when sdk attempts to invoke a callback that is null
### **Android**
#### **Change**
- Remove ARCore dependency
- Fix for crash that occurs when using utilizing Acquire Optimization feature
- Refined Google Play Store related data collection
### **Unity**
#### **Bugfix**
- Fix for crash that occurs when callback does not occur on main thread
- Fix for crash that occurs when UnityAds is included in a tvOS build

## [4.0.0] - 2021-11-30
### **iOS**
#### **Bugfix**
- Fix crash that occurs when commiting to metadata storage from multiple threads
### **Android**
#### **Bugfix**
- Prevent crash that would occur if Unity Ads is initialized with an empty activity
### **Unity**
#### **Bugfix**
- Fix Game Id textfields breaking in Windows
- Remove ENABLE_EDITOR_GAME_SERVICES from Top Menu

## [3.7.5] - 2021-07-20
### Android
Fix a crash that can occur when re-initializing with null gameId

## [3.7.3] - 2021-05-26
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[Android] Fix crash related to IllegalStateException when showing ad
[Android] Fix issue with attempting to load multiple ads at the same time causing load error
[iOS] Fix for crash that could occur when placementId became null
[iOS] Fixed warning when trying to access UIKit from background thread
[Unity] Fix a bug that caused the default placement to be unable to show

## [3.7.1] - 2021-03-31
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[iOS] Fixed iOS memory consumption to decrease chance of impact to device performance

## [3.7.0] - 2021-03-19
### Unity (Editor, Asset Store, & Packman)
#### Features
Added callbacks for the Show method signature on public API.
#### Changes
Improved Load method callbacks to include an error message.

## [3.6.2] - 2020-12-10
[Android] Fix a crash due to a ConcurrentModificationException

## [3.6.1] - 2020-12-10
No changes from 3.6.0

## [3.6.0] - 2020-12-08
No changes from 3.5.2

## [3.5.2] - 2020-11-12
No changes from 3.5.1

## [3.5.1] - 2020-11-05
#### Bug Fixes
[iOS] Address crash related to native metrics
[iOS] Address crash when using UUID SKAdNetwork appsheet parameters

## [3.5.0] - 2020-08-24
### Unity (Editor, Asset Store, & Packman)
#### Features
[Android, iOS] Background download WebView Update 
#### Changes
[Android] Update targetSdkVersion to 29
[Android, iOS, Unity] Update the Unity Ads SDK License
#### Bug Fixes
[Android] AdUnit View doesn't regain focus after a system popup
[Android] Android background audio does not resume after ad closed
[Android] End card showing blank white page
[iOS] Ads automatically closing when press Done button in StoreKit on iOS14
[Unity] IUnityAdsListener interface methods are called twice in some devices

## [3.4.9] - 2020-07-24
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[Android] fix crash in Android API level 30 with getNetworkType
[Unity] Error when working on unsupported platforms

## [3.4.7] - 2020-06-09
### Unity (Editor, Asset Store, & Packman)
* No visible changes from 3.4.6

## [3.4.6] - 2020-06-04
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[Android] InitializationState Out of Memory Crash
[Android] GooglePlayStore rejection due to unsafe SSL
[Android] Android readFileBytes crash
[iOS] ios ads not respecting mute
[iOS] Crash when calling addDelegate
[Unity] Error building on unsupported platform in 2020.1+
[Unity] Remove UnityEditor.Advertisement.dll

## [3.4.5] - 2020-04-29
### Unity (Editor, Asset Store, & Packman)
* No visible changes from 3.4.4

## [3.4.4] - 2020-03-02
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[Editor] Fix missing reference to UnityEngine.UI

## [3.4.2] - 2020-01-15
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
[Editor] No error callback is called when an invalid game id is used in playmode
[Android] Fix onUnityAdsError Exception: No such proxy method
[Android] Fix FatalException from BufferredInputStream.Read() that occurs on some Android devices
[iOS] Fix UnityAdsCopyString and NSStringFromIl2CppString errors when building for debug
[iOS] Fix Banner is unexpectedly scaled when force landscape mode

## [3.4.1] - 2019-12-13
### Unity (Editor, Asset Store, & Packman)
#### Bug Fixes
- [Android] Fixed an issue where callbacks would not dispatch on android devices
- [Editor Only] Fix an issue where callbacks would not fire in the editor after running playmode more than 1 time
- [Editor Only] Fix an issue where the editor canvas would not display on top of all other objects in the scene
- [Editor Only] Fix an issue where the placeholder gameobject was visible in the users scene

## [3.4.0] - 2019-12-09
### Unity (Editor, Asset Store, & Packman)
#### Deprecated Monetization class.
#### Features
UADSDK-231 - Print warning message in Asset Store package to upgrade to packman
UADSDK-232 - Restore TestMode flag from services window in Unity 2020.1+
#### Bug Fixes
ABT-951 - Test ads in editor has buttons that don't stop click event propagation
UADSDK-236 - OnUnityAdsReady only called once per placement when running in the Unity Editor.
ABT-1057 - Google Play crash reports for SDK 3.3.1
### iOS
#### Deprecated Monetization class.
#### Removed example app for Monetization.
#### Deprecation of initialize method with listener as a param in favor of initialize method 
#### Bug Fixes
UADSDK-219 - Fix iOS isWiredHeadsetOn Memory Leak
ABT-1032 - iOS callback unityAdsDidError is not triggered when initialize with invalid gameId 
ABT-1052 - [iOS] App Crash Rate increased after upgraded to SDK 3.3.0
ABT-1061 - IronSource: count duplicated impressions caused by third party
### Android
#### Deprecated Monetization class.
#### Removed example app for Monetization.
#### Deprecation of initialize method with listener as a param in favor of initialize method without a listener.
#### Bug Fixes
ABT-933 - Google / Admob App Crashing in 3.1.0
UADSDK-238 - Listener.sendErrorEvent is broken on Android
UADSDK-244 - Re-Init on Android always blocks for at least 10s
ABT-1057 - Google Play crash reports for SDK 3.3.1
ABT-1061 - IronSource: count duplicated impressions caused by third party

### Documentation updates
#### Monetization
* Updated the [Monetization Stats API](MonetizationResourcesStatistics.md):
    * Documented new API.
    * Added a migration guide from Applifier API.
    * New 408 error code.

#### Advertising

* [Audience Pinpointer](AdvertisingOptimizationAudiencePinpointer.md) is now self-serve on the Acquire dashboard.
* Updated the [server-to-server install tracking](AdvertisingCampaignsInstallTracking.md) guide.

#### Programmatic
* Added the `bAge` field to [contextual data](ProgrammaticOptimizationContextualData.md).

## [3.3.0] - 2019-09-26
### Unity (Editor, Asset Store, & Packman)
#### Fixed
* Fixed an issue where callbacks would not be executed on the main thread
* Fixed an issue where calling RemoveListener in a callback would cause a crash

### iOS
#### Added
* OS 13 update: 
    * Deprecated UI webview. Due to Apple's changes, Unity Ads no longer supports iOS 7 and 8. 
* Banner optimization:
    * New banner API, featuring the [`UADSBannerView`](../manual/MonetizationResourcesApiIos.html#uadsbannerview) class.
    * The new API supports multiple banners in a single Placement, with flexible positioning.

#### Fixed
* iOS 13 AppSheet crash fix

### Android
#### Added
* Banner optimization:
    * New banner API, featuring the [`BannerView`](../manual/MonetizationResourcesApiAndroid.html#bannerview) class.
    * The new API supports multiple banners in a single Placement, with flexible positioning.

#### Fixed
* WebView onRenderProcessGone crash fix

### Documentation updates
#### Monetization
* Added a FAQ section for [Authorized Sellers for Apps](../Manual/MonetizationResourcesFaq.html#authorized-sellers-for-apps-faqs) (`app-ads.txt`), which is now supported.

#### Advertising
* Added a section on [source bidding](../Manual/AdvertisingCampaignsConfiguration.html#source-bidding).
* Added a section on [app targeting](../Manual/AdvertisingCampaignsConfiguration.html#app-targeting).
* Removed legacy dashboard and API guides, which are no longer supported.

#### Programmatic
* Added Open Measurement (OM) support fields, including:
    * [`source.omidpn`](../manual/ProgrammaticBidRequests.html#source-objects)
    * [`source.omidpv`](../manual/ProgrammaticBidRequests.html#source-objects)
    * [`imp.video.api`](../manual/ProgrammaticBidRequests.html#video-objects)
    * [`bid.api`](../manual/ProgrammaticBidResponses.html#bid-objects)
* Added [`app.publisher`](../manual/ProgrammaticBidRequests.html#app-objects) field.
* Added the [`bAge`](../manual/ProgrammaticOptimizationContextualData.html) (blocked age rating) field.

#### Legal
* Updated [GDPR compliance](../manual/LegalGdpr.html) to reflect Unity's opt-in approach to consent.

## [3.2.0] - 2019-07-22
### Unity (Editor, Asset Store, & Packman)
#### Added
* Added OMID viewability integration. Unity is now [IAB certified with VAST viewability](https://iabtechlab.com/blog/vast-4-1-open-measurement-the-long-awaited-video-verification-solution/).

#### Fixed
* In cases where you've installed both the package manager and Asset store versions of Unity Ads, the SDK now surfaces an error notifying you to remove one instance.
* Fixed an Android java proxy usage issue for Unity versions below 2017. This fixes a multiple listeners crash. 

### iOS
#### Added
* Added OMID viewability integration. Unity is now [IAB certified with VAST viewability](https://iabtechlab.com/blog/vast-4-1-open-measurement-the-long-awaited-video-verification-solution/).

### Android
#### Added
* Added OMID viewability integration. Unity is now [IAB certified with VAST viewability](https://iabtechlab.com/blog/vast-4-1-open-measurement-the-long-awaited-video-verification-solution/).

## [3.1.1] - 2019-05-16
#### Added
* Updated the Android and iOS binaries to 3.1.0.
* Support for multiple listeners.
* `ASWebAuthenticationSession` support.

#### Fixed
* Banner memory leak.
* `GetDeviceId` on Android SDK versions below 23.
* Volume change event not properly captured on iOS.
* `USRVStorage` JSON exception caught and handled.
* Analytics `onLevelUp` taking a string instead of an integer.
* Crash prevented in the `AdUnitActivity.onPause` event.
* Playstation and Xbox no longer throw errors attempting to access `UnityAdsSettings` when building a Project that includes ads on other platforms.
* Test mode resources folder moved to Editor-only scope.

## [3.0.3] - 2019-03-15
#### Added
* Updated the Android and iOS binaries.

#### Fixed
* https://fogbugz.unity3d.com/f/cases/1115398/
* Uncaught exception for purchasing integration on iOS.

## [3.0.2] - 2019-02-26
#### Added
* Updated the Android and iOS binaries.

#### Fixed
* https://fogbugz.unity3d.com/f/cases/1127423/
* https://fogbugz.unity3d.com/f/cases/1127770/

## [3.0.1] - 2019-01-25
#### Added
* Integrated the Ads 3.0.1 SDK.

## [2.3.2] - 2018-11-21
#### Added
* Integrated the Ads 2.3.0 SDK with Unity 2019.X.

#### Fixed
* https://fogbugz.unity3d.com/f/cases/1107128/
* https://fogbugz.unity3d.com/f/cases/1108663/

## [2.3.1] - 2018-11-15
#### Added
* Updated to Ads 2.3.0 SDK.
* Multithreaded Request API.
* `SendEvent` API for Ads and IAP SDK communication.
* New Unity integration.

## [2.2.1] - 2017-04-23
#### Fixed
* Fixed issues for iOS and Android.

## [2.2.0] - 2017-03-22
#### Added
* IAP Promotion support (iOS, Android).

#### Fixed
* Several rare crashes (iOS).

#### Changed
* Improved cache handling (iOS, Android).
* Increased flexibility showing different ad formats (iOS, Android).