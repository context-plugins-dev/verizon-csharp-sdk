using System.Net.Http;
using Verizon.Api;
using Verizon.Core;
using Verizon.Core.Logging;
using Verizon.Core.Models;

namespace Verizon;

/// <summary>
/// "The Connection Planner is a service that provides devices windows to connect to their backend APIs. The service validates device access permissions and processes valid devices asynchronously. For each batch, it retrieves device connectivity windows from the RAN KPI Data Application, and sends callbacks back to customers via UWS-Callback for both successful and failed device requests."
/// </summary>
public sealed class VerizonClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public VerizonClient(HttpClient httpClient, VerizonClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "VerizonClient/v1.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "v1.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "VerizonClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options, _server, _rawClient);
    }

    /// <summary>
    /// Activate devices or retrieve device attributes.
    /// </summary>
    public GbiDeviceActions5 GbiDeviceActions5 => field ??= new GbiDeviceActions5(_rawClient, _server, _auth);

    /// <summary>
    /// Device information for an account.
    /// </summary>
    public AccountDevices AccountDevices => field ??= new AccountDevices(_rawClient, _server, _auth);

    /// <summary>
    /// Get the status of asynchronous reqeusts.
    /// </summary>
    public AccountRequests AccountRequests => field ??= new AccountRequests(_rawClient, _server, _auth);

    /// <summary>
    /// Account Information for a specified Account Name.
    /// </summary>
    public AccountServiceController AccountServiceController =>
        field ??= new AccountServiceController(_rawClient, _server, _auth);

    public AccountSubscriptions AccountSubscriptions => field ??= new AccountSubscriptions(_rawClient, _server, _auth);

    /// <summary>
    /// Get information about an account or account leads.
    /// </summary>
    public Accounts Accounts => field ??= new Accounts(_rawClient, _server, _auth);

    /// <summary>
    /// Choose what level and interval of alerting for anomalies detected.
    /// </summary>
    public AnomalySettings AnomalySettings => field ??= new AnomalySettings(_rawClient, _server, _auth);

    /// <summary>
    /// Set the threshold of notification for anomalies detected.
    /// </summary>
    public AnomalyTriggers AnomalyTriggers => field ??= new AnomalyTriggers(_rawClient, _server, _auth);

    public AnomalyTriggersV2 AnomalyTriggersV2 => field ??= new AnomalyTriggersV2(_rawClient, _server, _auth);

    public Billing Billing => field ??= new Billing(_rawClient, _server, _auth);

    /// <summary>
    /// Schedule, retrieve or cancel scheduled FOTA campaigns.
    /// </summary>
    public CampaignsV2 CampaignsV2 => field ??= new CampaignsV2(_rawClient, _server, _auth);

    /// <summary>
    /// Schedule, retrieve or cancel scheduled FOTA campaigns.
    /// </summary>
    public CampaignsV3 CampaignsV3 => field ??= new CampaignsV3(_rawClient, _server, _auth);

    /// <summary>
    /// Device logs stored on the device itself.
    /// </summary>
    public ClientLogging ClientLogging => field ??= new ClientLogging(_rawClient, _server, _auth);

    public CloudConnectorDevices CloudConnectorDevices =>
        field ??= new CloudConnectorDevices(_rawClient, _server, _auth);

    public CloudConnectorSubscriptions CloudConnectorSubscriptions =>
        field ??= new CloudConnectorSubscriptions(_rawClient, _server, _auth);

    public ConfigurationFiles ConfigurationFiles => field ??= new ConfigurationFiles(_rawClient, _server, _auth);

    /// <summary>
    /// Manage subscriptions to asynchronous webhook messages.
    /// </summary>
    public ConnectivityCallbacks ConnectivityCallbacks =>
        field ??= new ConnectivityCallbacks(_rawClient, _server, _auth);

    /// <summary>
    /// Create rules to trigger changes for price plans based on usage
    /// </summary>
    public CreatePricePlanTriggers CreatePricePlanTriggers =>
        field ??= new CreatePricePlanTriggers(_rawClient, _server, _auth);

    /// <summary>
    /// Device management for either Verizon (lead) or Global (local) profiles.
    /// </summary>
    public DeviceActions DeviceActions => field ??= new DeviceActions(_rawClient, _server, _auth);

    /// <summary>
    /// API endpoints for managing HPL device credentials
    /// </summary>
    public DeviceCredentialManagement DeviceCredentialManagement =>
        field ??= new DeviceCredentialManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Helps to create &amp; manage diagnostics
    /// </summary>
    public DeviceDiagnostics DeviceDiagnostics => field ??= new DeviceDiagnostics(_rawClient, _server, _auth);

    /// <summary>
    /// Manage device groups.
    /// </summary>
    public DeviceGroups DeviceGroups => field ??= new DeviceGroups(_rawClient, _server, _auth);

    /// <summary>
    /// Receive notifications from the API.
    /// </summary>
    public DeviceLocationCallbacks DeviceLocationCallbacks =>
        field ??= new DeviceLocationCallbacks(_rawClient, _server, _auth);

    /// <summary>
    /// Manage device connectivity and get device history.
    /// </summary>
    public DeviceManagement DeviceManagement => field ??= new DeviceManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Monitor device reachability and connection status.
    /// </summary>
    public DeviceMonitoring DeviceMonitoring => field ??= new DeviceMonitoring(_rawClient, _server, _auth);

    public DeviceProfileManagement DeviceProfileManagement =>
        field ??= new DeviceProfileManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Check device usage
    /// </summary>
    public DeviceReports DeviceReports => field ??= new DeviceReports(_rawClient, _server, _auth);

    /// <summary>
    /// Send Short Message Service (SMS) messages to devices
    /// </summary>
    public DeviceSmsMessaging DeviceSmsMessaging => field ??= new DeviceSmsMessaging(_rawClient, _server, _auth);

    /// <summary>
    /// Check status and enable or disable service for Hyper Precise
    /// </summary>
    public DeviceServiceManagement DeviceServiceManagement =>
        field ??= new DeviceServiceManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Get an account's location service subscription status and usage.
    /// </summary>
    public DevicesLocationSubscriptions DevicesLocationSubscriptions =>
        field ??= new DevicesLocationSubscriptions(_rawClient, _server, _auth);

    /// <summary>
    /// Locate devices.
    /// </summary>
    public DevicesLocations DevicesLocations => field ??= new DevicesLocations(_rawClient, _server, _auth);

    public DiagnosticsCallbacks DiagnosticsCallbacks => field ??= new DiagnosticsCallbacks(_rawClient, _server, _auth);

    public DiagnosticsFactoryReset DiagnosticsFactoryReset =>
        field ??= new DiagnosticsFactoryReset(_rawClient, _server, _auth);

    public DiagnosticsHistory DiagnosticsHistory => field ??= new DiagnosticsHistory(_rawClient, _server, _auth);

    public DiagnosticsObservations DiagnosticsObservations =>
        field ??= new DiagnosticsObservations(_rawClient, _server, _auth);

    public DiagnosticsSettings DiagnosticsSettings => field ??= new DiagnosticsSettings(_rawClient, _server, _auth);

    public DiagnosticsSubscriptions DiagnosticsSubscriptions =>
        field ??= new DiagnosticsSubscriptions(_rawClient, _server, _auth);

    /// <summary>
    /// Manage geofence-based application configurations.
    /// </summary>
    public EtxAppConfiguration EtxAppConfiguration => field ??= new EtxAppConfiguration(_rawClient, _server, _auth);

    /// <summary>
    /// Manage device registration and connection.
    /// </summary>
    public EtxRegistration EtxRegistration => field ??= new EtxRegistration(_rawClient, _server, _auth);

    /// <summary>
    /// Exclude devices from location services.
    /// </summary>
    public Exclusions Exclusions => field ??= new Exclusions(_rawClient, _server, _auth);

    /// <summary>
    /// Schedule and monitor firmware upgrades.
    /// </summary>
    public FirmwareV1 FirmwareV1 => field ??= new FirmwareV1(_rawClient, _server, _auth);

    /// <summary>
    /// State of Firmware across devices in the account.
    /// </summary>
    public FirmwareV3 FirmwareV3 => field ??= new FirmwareV3(_rawClient, _server, _auth);

    /// <summary>
    /// Use these endpoints to determine the status of requests or the history of device provisioning.
    /// </summary>
    public GlobalReporting GlobalReporting => field ??= new GlobalReporting(_rawClient, _server, _auth);

    /// <summary>
    /// Manage the devices on the account
    /// </summary>
    public HplDeviceManagement HplDeviceManagement => field ??= new HplDeviceManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Manage callback listeners for Hyper Precise
    /// </summary>
    public HyperPreciseLocationCallbacks HyperPreciseLocationCallbacks =>
        field ??= new HyperPreciseLocationCallbacks(_rawClient, _server, _auth);

    /// <summary>
    /// ThingSpace Intelligence is an offering of integrated connectivity and service management.
    /// </summary>
    public IntelligenceServiceController IntelligenceServiceController =>
        field ??= new IntelligenceServiceController(_rawClient, _server, _auth);

    /// <summary>
    /// Manage Global IoT Orchestration device profiles for either Verizon (lead) or Global (local).
    /// </summary>
    public ManagingESimProfiles ManagingESimProfiles => field ??= new ManagingESimProfiles(_rawClient, _server, _auth);

    public Pwn Pwn => field ??= new Pwn(_rawClient, _server, _auth);

    /// <summary>
    /// Retrieve status and information about the promotion period for using a pseudo-MDN (Mobile Device Number))
    /// </summary>
    public PromotionPeriodInformation PromotionPeriodInformation =>
        field ??= new PromotionPeriodInformation(_rawClient, _server, _auth);

    /// <summary>
    /// Retrive a list of the rate plans associated with the account
    /// </summary>
    public RetrieveRatePlanList RetrieveRatePlanList => field ??= new RetrieveRatePlanList(_rawClient, _server, _auth);

    /// <summary>
    /// Retrieve the triggers associated with the feature and the account.
    /// </summary>
    public RetrieveTheTriggers RetrieveTheTriggers => field ??= new RetrieveTheTriggers(_rawClient, _server, _auth);

    /// <summary>
    /// Activate and Deactivate the SIM.
    /// </summary>
    public SimActions SimActions => field ??= new SimActions(_rawClient, _server, _auth);

    public SimSecureForIoTLicenses SimSecureForIoTLicenses =>
        field ??= new SimSecureForIoTLicenses(_rawClient, _server, _auth);

    /// <summary>
    /// Exchange Short Message Service (SMS) messages with devices.
    /// </summary>
    public Sms Sms => field ??= new Sms(_rawClient, _server, _auth);

    /// <summary>
    /// Create and manage device profile information
    /// </summary>
    public SensorInsightsDeviceProfile SensorInsightsDeviceProfile =>
        field ??= new SensorInsightsDeviceProfile(_rawClient, _server, _auth);

    /// <summary>
    /// Device tasks and information
    /// </summary>
    public SensorInsightsDevices SensorInsightsDevices =>
        field ??= new SensorInsightsDevices(_rawClient, _server, _auth);

    /// <summary>
    /// Query gateway information
    /// </summary>
    public SensorInsightsGateways SensorInsightsGateways =>
        field ??= new SensorInsightsGateways(_rawClient, _server, _auth);

    /// <summary>
    /// Monitor the health of devices and the network
    /// </summary>
    public SensorInsightsHealthScore SensorInsightsHealthScore =>
        field ??= new SensorInsightsHealthScore(_rawClient, _server, _auth);

    /// <summary>
    /// Create and manage groups to recieve notifications and alerts
    /// </summary>
    public SensorInsightsNotificationGroups SensorInsightsNotificationGroups =>
        field ??= new SensorInsightsNotificationGroups(_rawClient, _server, _auth);

    /// <summary>
    /// Create and manage rules
    /// </summary>
    public SensorInsightsRules SensorInsightsRules => field ??= new SensorInsightsRules(_rawClient, _server, _auth);

    /// <summary>
    /// Sensor tasks and information
    /// </summary>
    public SensorInsightsSensors SensorInsightsSensors =>
        field ??= new SensorInsightsSensors(_rawClient, _server, _auth);

    /// <summary>
    /// Retrieve tallies of alerts from a recent daily period
    /// </summary>
    public SensorInsightsSmartAlertMetrics SensorInsightsSmartAlertMetrics =>
        field ??= new SensorInsightsSmartAlertMetrics(_rawClient, _server, _auth);

    /// <summary>
    /// Rules based alerts
    /// </summary>
    public SensorInsightsSmartAlerts SensorInsightsSmartAlerts =>
        field ??= new SensorInsightsSmartAlerts(_rawClient, _server, _auth);

    /// <summary>
    /// Create user accounts and manage user roles and permissions
    /// </summary>
    public SensorInsightsUsers SensorInsightsUsers => field ??= new SensorInsightsUsers(_rawClient, _server, _auth);

    /// <summary>
    /// Device logs on the server.
    /// </summary>
    public ServerLogging ServerLogging => field ??= new ServerLogging(_rawClient, _server, _auth);

    /// <summary>
    /// Get a list of service plans in an account.
    /// </summary>
    public ServicePlans ServicePlans => field ??= new ServicePlans(_rawClient, _server, _auth);

    /// <summary>
    /// Start and end Connectivity Management sessions.
    /// </summary>
    public SessionManagement SessionManagement => field ??= new SessionManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Register and deregister callback endpoints.
    /// </summary>
    public SoftwareManagementCallbacksV1 SoftwareManagementCallbacksV1 =>
        field ??= new SoftwareManagementCallbacksV1(_rawClient, _server, _auth);

    /// <summary>
    /// Find registered callbacks or create, update and delete a registered callback.
    /// </summary>
    public SoftwareManagementCallbacksV2 SoftwareManagementCallbacksV2 =>
        field ??= new SoftwareManagementCallbacksV2(_rawClient, _server, _auth);

    /// <summary>
    /// Find registered callbacks or create, update and delete a registered callback.
    /// </summary>
    public SoftwareManagementCallbacksV3 SoftwareManagementCallbacksV3 =>
        field ??= new SoftwareManagementCallbacksV3(_rawClient, _server, _auth);

    /// <summary>
    /// Assign Software Management Services license to devices <b>Note:</b>These endpoints have been deprecated. Please use the <b>v3</b> endpoints.
    /// </summary>
    public SoftwareManagementLicensesV1 SoftwareManagementLicensesV1 =>
        field ??= new SoftwareManagementLicensesV1(_rawClient, _server, _auth);

    /// <summary>
    /// License status and assignment.
    /// </summary>
    public SoftwareManagementLicensesV2 SoftwareManagementLicensesV2 =>
        field ??= new SoftwareManagementLicensesV2(_rawClient, _server, _auth);

    /// <summary>
    /// License status and assignment.
    /// </summary>
    public SoftwareManagementLicensesV3 SoftwareManagementLicensesV3 =>
        field ??= new SoftwareManagementLicensesV3(_rawClient, _server, _auth);

    /// <summary>
    /// Status and history information.
    /// </summary>
    public SoftwareManagementReportsV1 SoftwareManagementReportsV1 =>
        field ??= new SoftwareManagementReportsV1(_rawClient, _server, _auth);

    /// <summary>
    /// Status of a campaign per device.
    /// </summary>
    public SoftwareManagementReportsV2 SoftwareManagementReportsV2 =>
        field ??= new SoftwareManagementReportsV2(_rawClient, _server, _auth);

    /// <summary>
    /// Status of a campaign per device.
    /// </summary>
    public SoftwareManagementReportsV3 SoftwareManagementReportsV3 =>
        field ??= new SoftwareManagementReportsV3(_rawClient, _server, _auth);

    /// <summary>
    /// View Software Management Services subscription status.
    /// </summary>
    public SoftwareManagementSubscriptionsV1 SoftwareManagementSubscriptionsV1 =>
        field ??= new SoftwareManagementSubscriptionsV1(_rawClient, _server, _auth);

    /// <summary>
    /// Information about current FOTA subscriptions.
    /// </summary>
    public SoftwareManagementSubscriptionsV2 SoftwareManagementSubscriptionsV2 =>
        field ??= new SoftwareManagementSubscriptionsV2(_rawClient, _server, _auth);

    /// <summary>
    /// Information about current FOTA subscriptions.
    /// </summary>
    public SoftwareManagementSubscriptionsV3 SoftwareManagementSubscriptionsV3 =>
        field ??= new SoftwareManagementSubscriptionsV3(_rawClient, _server, _auth);

    public Targets Targets => field ??= new Targets(_rawClient, _server, _auth);

    /// <summary>
    /// Subscribe or Unsubscribe to the ThingSpace Quality of Service API.
    /// </summary>
    public ThingSpaceQualityOfServiceApiActions ThingSpaceQualityOfServiceApiActions =>
        field ??= new ThingSpaceQualityOfServiceApiActions(_rawClient, _server, _auth);

    /// <summary>
    /// Update rules to trigger changes for price plans based on usage
    /// </summary>
    public UpdatePricePlanTriggers UpdatePricePlanTriggers =>
        field ??= new UpdatePricePlanTriggers(_rawClient, _server, _auth);

    /// <summary>
    /// Updates the trigger threshold values for alerts.
    /// </summary>
    public UpdateTriggers UpdateTriggers => field ??= new UpdateTriggers(_rawClient, _server, _auth);

    public UsageTriggerManagement UsageTriggerManagement =>
        field ??= new UsageTriggerManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Run reports to query current network conditions, historic network conditions, see what wireless technologies are supported in your area or qualify and address for Fixed Wireless Access (FWA).
    /// </summary>
    public WirelessNetworkPerformance WirelessNetworkPerformance =>
        field ??= new WirelessNetworkPerformance(_rawClient, _server, _auth);

    public DeviceRoleController DeviceRoleController => field ??= new DeviceRoleController(_rawClient, _server, _auth);

    public EUiccDeviceProfileManagement EUiccDeviceProfileManagement =>
        field ??= new EUiccDeviceProfileManagement(_rawClient, _server, _auth);

    /// <summary>
    /// Endpoints for ingesting, querying, and deleting V2X MAP messages.
    /// </summary>
    public MapMessageController MapMessageController => field ??= new MapMessageController(_rawClient, _server, _auth);
}
