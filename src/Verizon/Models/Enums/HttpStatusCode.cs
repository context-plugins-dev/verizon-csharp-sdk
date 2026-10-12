using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// HTML error code and description.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HttpStatusCode>))]
public sealed record HttpStatusCode : OpenStringEnum<HttpStatusCode>
{
    private HttpStatusCode(string value) : base(value)
    {
    }

    public static readonly HttpStatusCode _100Continue = new("100 CONTINUE");

    public static readonly HttpStatusCode _101SwitchingProtocols = new("101 SWITCHING_PROTOCOLS");

    public static readonly HttpStatusCode _102Processing = new("102 PROCESSING");

    public static readonly HttpStatusCode _103Checkpoint = new("103 CHECKPOINT");

    public static readonly HttpStatusCode _200Ok = new("200 OK");

    public static readonly HttpStatusCode _201Created = new("201 CREATED");

    public static readonly HttpStatusCode _202Accepted = new("202 ACCEPTED");

    public static readonly HttpStatusCode _203NonAuthoritativeInformation = new("203 NON_AUTHORITATIVE_INFORMATION");

    public static readonly HttpStatusCode _204NoContent = new("204 NO_CONTENT");

    public static readonly HttpStatusCode _205ResetContent = new("205 RESET_CONTENT");

    public static readonly HttpStatusCode _206PartialContent = new("206 PARTIAL_CONTENT");

    public static readonly HttpStatusCode _207MultiStatus = new("207 MULTI_STATUS");

    public static readonly HttpStatusCode _208AlreadyReported = new("208 ALREADY_REPORTED");

    public static readonly HttpStatusCode _226ImUsed = new("226 IM_USED");

    public static readonly HttpStatusCode _300MultipleChoices = new("300 MULTIPLE_CHOICES");

    public static readonly HttpStatusCode _301MovedPermanently = new("301 MOVED_PERMANENTLY");

    public static readonly HttpStatusCode _302Found = new("302 FOUND");

    public static readonly HttpStatusCode _302MovedTemporarily = new("302 MOVED_TEMPORARILY");

    public static readonly HttpStatusCode _303SeeOther = new("303 SEE_OTHER");

    public static readonly HttpStatusCode _304NotModified = new("304 NOT_MODIFIED");

    public static readonly HttpStatusCode _305UseProxy = new("305 USE_PROXY");

    public static readonly HttpStatusCode _307TemporaryRedirect = new("307 TEMPORARY_REDIRECT");

    public static readonly HttpStatusCode _308PermanentRedirect = new("308 PERMANENT_REDIRECT");

    public static readonly HttpStatusCode _400BadRequest = new("400 BAD_REQUEST");

    public static readonly HttpStatusCode _401Unauthorized = new("401 UNAUTHORIZED");

    public static readonly HttpStatusCode _402PaymentRequired = new("402 PAYMENT_REQUIRED");

    public static readonly HttpStatusCode _403Forbidden = new("403 FORBIDDEN");

    public static readonly HttpStatusCode _404NotFound = new("404 NOT_FOUND");

    public static readonly HttpStatusCode _405MethodNotAllowed = new("405 METHOD_NOT_ALLOWED");

    public static readonly HttpStatusCode _406NotAcceptable = new("406 NOT_ACCEPTABLE");

    public static readonly HttpStatusCode _407ProxyAuthenticationRequired = new("407 PROXY_AUTHENTICATION_REQUIRED");

    public static readonly HttpStatusCode _408RequestTimeout = new("408 REQUEST_TIMEOUT");

    public static readonly HttpStatusCode _409Conflict = new("409 CONFLICT");

    public static readonly HttpStatusCode _410Gone = new("410 GONE");

    public static readonly HttpStatusCode _411LengthRequired = new("411 LENGTH_REQUIRED");

    public static readonly HttpStatusCode _412PreconditionFailed = new("412 PRECONDITION_FAILED");

    public static readonly HttpStatusCode _413PayloadTooLarge = new("413 PAYLOAD_TOO_LARGE");

    public static readonly HttpStatusCode _413RequestEntityTooLarge = new("413 REQUEST_ENTITY_TOO_LARGE");

    public static readonly HttpStatusCode _414UriTooLong = new("414 URI_TOO_LONG");

    public static readonly HttpStatusCode _414RequestUriTooLong = new("414 REQUEST_URI_TOO_LONG");

    public static readonly HttpStatusCode _415UnsupportedMediaType = new("415 UNSUPPORTED_MEDIA_TYPE");

    public static readonly HttpStatusCode _416RequestedRangeNotSatisfiable = new("416 REQUESTED_RANGE_NOT_SATISFIABLE");

    public static readonly HttpStatusCode _417ExpectationFailed = new("417 EXPECTATION_FAILED");

    public static readonly HttpStatusCode _418IAmATeapot = new("418 I_AM_A_TEAPOT");

    public static readonly HttpStatusCode _419InsufficientSpaceOnResource = new("419 INSUFFICIENT_SPACE_ON_RESOURCE");

    public static readonly HttpStatusCode _420MethodFailure = new("420 METHOD_FAILURE");

    public static readonly HttpStatusCode _421DestinationLocked = new("421 DESTINATION_LOCKED");

    public static readonly HttpStatusCode _422UnprocessableEntity = new("422 UNPROCESSABLE_ENTITY");

    public static readonly HttpStatusCode _423Locked = new("423 LOCKED");

    public static readonly HttpStatusCode _424FailedDependency = new("424 FAILED_DEPENDENCY");

    public static readonly HttpStatusCode _425TooEarly = new("425 TOO_EARLY");

    public static readonly HttpStatusCode _426UpgradeRequired = new("426 UPGRADE_REQUIRED");

    public static readonly HttpStatusCode _428PreconditionRequired = new("428 PRECONDITION_REQUIRED");

    public static readonly HttpStatusCode _429TooManyRequests = new("429 TOO_MANY_REQUESTS");

    public static readonly HttpStatusCode _431RequestHeaderFieldsTooLarge = new("431 REQUEST_HEADER_FIELDS_TOO_LARGE");

    public static readonly HttpStatusCode _451UnavailableForLegalReasons = new("451 UNAVAILABLE_FOR_LEGAL_REASONS");

    public static readonly HttpStatusCode _500InternalServerError = new("500 INTERNAL_SERVER_ERROR");

    public static readonly HttpStatusCode _501NotImplemented = new("501 NOT_IMPLEMENTED");

    public static readonly HttpStatusCode _502BadGateway = new("502 BAD_GATEWAY");

    public static readonly HttpStatusCode _503ServiceUnavailable = new("503 SERVICE_UNAVAILABLE");

    public static readonly HttpStatusCode _504GatewayTimeout = new("504 GATEWAY_TIMEOUT");

    public static readonly HttpStatusCode _505HttpVersionNotSupported = new("505 HTTP_VERSION_NOT_SUPPORTED");

    public static readonly HttpStatusCode _506VariantAlsoNegotiates = new("506 VARIANT_ALSO_NEGOTIATES");

    public static readonly HttpStatusCode _507InsufficientStorage = new("507 INSUFFICIENT_STORAGE");

    public static readonly HttpStatusCode _508LoopDetected = new("508 LOOP_DETECTED");

    public static readonly HttpStatusCode _509BandwidthLimitExceeded = new("509 BANDWIDTH_LIMIT_EXCEEDED");

    public static readonly HttpStatusCode _510NotExtended = new("510 NOT_EXTENDED");

    public static readonly HttpStatusCode _511NetworkAuthenticationRequired = new(
        "511 NETWORK_AUTHENTICATION_REQUIRED");

    public TResult Match<TResult>(Func<TResult> on_100Continue,
        Func<TResult> on_101SwitchingProtocols,
        Func<TResult> on_102Processing,
        Func<TResult> on_103Checkpoint,
        Func<TResult> on_200Ok,
        Func<TResult> on_201Created,
        Func<TResult> on_202Accepted,
        Func<TResult> on_203NonAuthoritativeInformation,
        Func<TResult> on_204NoContent,
        Func<TResult> on_205ResetContent,
        Func<TResult> on_206PartialContent,
        Func<TResult> on_207MultiStatus,
        Func<TResult> on_208AlreadyReported,
        Func<TResult> on_226ImUsed,
        Func<TResult> on_300MultipleChoices,
        Func<TResult> on_301MovedPermanently,
        Func<TResult> on_302Found,
        Func<TResult> on_302MovedTemporarily,
        Func<TResult> on_303SeeOther,
        Func<TResult> on_304NotModified,
        Func<TResult> on_305UseProxy,
        Func<TResult> on_307TemporaryRedirect,
        Func<TResult> on_308PermanentRedirect,
        Func<TResult> on_400BadRequest,
        Func<TResult> on_401Unauthorized,
        Func<TResult> on_402PaymentRequired,
        Func<TResult> on_403Forbidden,
        Func<TResult> on_404NotFound,
        Func<TResult> on_405MethodNotAllowed,
        Func<TResult> on_406NotAcceptable,
        Func<TResult> on_407ProxyAuthenticationRequired,
        Func<TResult> on_408RequestTimeout,
        Func<TResult> on_409Conflict,
        Func<TResult> on_410Gone,
        Func<TResult> on_411LengthRequired,
        Func<TResult> on_412PreconditionFailed,
        Func<TResult> on_413PayloadTooLarge,
        Func<TResult> on_413RequestEntityTooLarge,
        Func<TResult> on_414UriTooLong,
        Func<TResult> on_414RequestUriTooLong,
        Func<TResult> on_415UnsupportedMediaType,
        Func<TResult> on_416RequestedRangeNotSatisfiable,
        Func<TResult> on_417ExpectationFailed,
        Func<TResult> on_418IAmATeapot,
        Func<TResult> on_419InsufficientSpaceOnResource,
        Func<TResult> on_420MethodFailure,
        Func<TResult> on_421DestinationLocked,
        Func<TResult> on_422UnprocessableEntity,
        Func<TResult> on_423Locked,
        Func<TResult> on_424FailedDependency,
        Func<TResult> on_425TooEarly,
        Func<TResult> on_426UpgradeRequired,
        Func<TResult> on_428PreconditionRequired,
        Func<TResult> on_429TooManyRequests,
        Func<TResult> on_431RequestHeaderFieldsTooLarge,
        Func<TResult> on_451UnavailableForLegalReasons,
        Func<TResult> on_500InternalServerError,
        Func<TResult> on_501NotImplemented,
        Func<TResult> on_502BadGateway,
        Func<TResult> on_503ServiceUnavailable,
        Func<TResult> on_504GatewayTimeout,
        Func<TResult> on_505HttpVersionNotSupported,
        Func<TResult> on_506VariantAlsoNegotiates,
        Func<TResult> on_507InsufficientStorage,
        Func<TResult> on_508LoopDetected,
        Func<TResult> on_509BandwidthLimitExceeded,
        Func<TResult> on_510NotExtended,
        Func<TResult> on_511NetworkAuthenticationRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _100Continue => on_100Continue(),
            _ when this == _101SwitchingProtocols => on_101SwitchingProtocols(),
            _ when this == _102Processing => on_102Processing(),
            _ when this == _103Checkpoint => on_103Checkpoint(),
            _ when this == _200Ok => on_200Ok(),
            _ when this == _201Created => on_201Created(),
            _ when this == _202Accepted => on_202Accepted(),
            _ when this == _203NonAuthoritativeInformation => on_203NonAuthoritativeInformation(),
            _ when this == _204NoContent => on_204NoContent(),
            _ when this == _205ResetContent => on_205ResetContent(),
            _ when this == _206PartialContent => on_206PartialContent(),
            _ when this == _207MultiStatus => on_207MultiStatus(),
            _ when this == _208AlreadyReported => on_208AlreadyReported(),
            _ when this == _226ImUsed => on_226ImUsed(),
            _ when this == _300MultipleChoices => on_300MultipleChoices(),
            _ when this == _301MovedPermanently => on_301MovedPermanently(),
            _ when this == _302Found => on_302Found(),
            _ when this == _302MovedTemporarily => on_302MovedTemporarily(),
            _ when this == _303SeeOther => on_303SeeOther(),
            _ when this == _304NotModified => on_304NotModified(),
            _ when this == _305UseProxy => on_305UseProxy(),
            _ when this == _307TemporaryRedirect => on_307TemporaryRedirect(),
            _ when this == _308PermanentRedirect => on_308PermanentRedirect(),
            _ when this == _400BadRequest => on_400BadRequest(),
            _ when this == _401Unauthorized => on_401Unauthorized(),
            _ when this == _402PaymentRequired => on_402PaymentRequired(),
            _ when this == _403Forbidden => on_403Forbidden(),
            _ when this == _404NotFound => on_404NotFound(),
            _ when this == _405MethodNotAllowed => on_405MethodNotAllowed(),
            _ when this == _406NotAcceptable => on_406NotAcceptable(),
            _ when this == _407ProxyAuthenticationRequired => on_407ProxyAuthenticationRequired(),
            _ when this == _408RequestTimeout => on_408RequestTimeout(),
            _ when this == _409Conflict => on_409Conflict(),
            _ when this == _410Gone => on_410Gone(),
            _ when this == _411LengthRequired => on_411LengthRequired(),
            _ when this == _412PreconditionFailed => on_412PreconditionFailed(),
            _ when this == _413PayloadTooLarge => on_413PayloadTooLarge(),
            _ when this == _413RequestEntityTooLarge => on_413RequestEntityTooLarge(),
            _ when this == _414UriTooLong => on_414UriTooLong(),
            _ when this == _414RequestUriTooLong => on_414RequestUriTooLong(),
            _ when this == _415UnsupportedMediaType => on_415UnsupportedMediaType(),
            _ when this == _416RequestedRangeNotSatisfiable => on_416RequestedRangeNotSatisfiable(),
            _ when this == _417ExpectationFailed => on_417ExpectationFailed(),
            _ when this == _418IAmATeapot => on_418IAmATeapot(),
            _ when this == _419InsufficientSpaceOnResource => on_419InsufficientSpaceOnResource(),
            _ when this == _420MethodFailure => on_420MethodFailure(),
            _ when this == _421DestinationLocked => on_421DestinationLocked(),
            _ when this == _422UnprocessableEntity => on_422UnprocessableEntity(),
            _ when this == _423Locked => on_423Locked(),
            _ when this == _424FailedDependency => on_424FailedDependency(),
            _ when this == _425TooEarly => on_425TooEarly(),
            _ when this == _426UpgradeRequired => on_426UpgradeRequired(),
            _ when this == _428PreconditionRequired => on_428PreconditionRequired(),
            _ when this == _429TooManyRequests => on_429TooManyRequests(),
            _ when this == _431RequestHeaderFieldsTooLarge => on_431RequestHeaderFieldsTooLarge(),
            _ when this == _451UnavailableForLegalReasons => on_451UnavailableForLegalReasons(),
            _ when this == _500InternalServerError => on_500InternalServerError(),
            _ when this == _501NotImplemented => on_501NotImplemented(),
            _ when this == _502BadGateway => on_502BadGateway(),
            _ when this == _503ServiceUnavailable => on_503ServiceUnavailable(),
            _ when this == _504GatewayTimeout => on_504GatewayTimeout(),
            _ when this == _505HttpVersionNotSupported => on_505HttpVersionNotSupported(),
            _ when this == _506VariantAlsoNegotiates => on_506VariantAlsoNegotiates(),
            _ when this == _507InsufficientStorage => on_507InsufficientStorage(),
            _ when this == _508LoopDetected => on_508LoopDetected(),
            _ when this == _509BandwidthLimitExceeded => on_509BandwidthLimitExceeded(),
            _ when this == _510NotExtended => on_510NotExtended(),
            _ when this == _511NetworkAuthenticationRequired => on_511NetworkAuthenticationRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action on_100Continue,
        Action on_101SwitchingProtocols,
        Action on_102Processing,
        Action on_103Checkpoint,
        Action on_200Ok,
        Action on_201Created,
        Action on_202Accepted,
        Action on_203NonAuthoritativeInformation,
        Action on_204NoContent,
        Action on_205ResetContent,
        Action on_206PartialContent,
        Action on_207MultiStatus,
        Action on_208AlreadyReported,
        Action on_226ImUsed,
        Action on_300MultipleChoices,
        Action on_301MovedPermanently,
        Action on_302Found,
        Action on_302MovedTemporarily,
        Action on_303SeeOther,
        Action on_304NotModified,
        Action on_305UseProxy,
        Action on_307TemporaryRedirect,
        Action on_308PermanentRedirect,
        Action on_400BadRequest,
        Action on_401Unauthorized,
        Action on_402PaymentRequired,
        Action on_403Forbidden,
        Action on_404NotFound,
        Action on_405MethodNotAllowed,
        Action on_406NotAcceptable,
        Action on_407ProxyAuthenticationRequired,
        Action on_408RequestTimeout,
        Action on_409Conflict,
        Action on_410Gone,
        Action on_411LengthRequired,
        Action on_412PreconditionFailed,
        Action on_413PayloadTooLarge,
        Action on_413RequestEntityTooLarge,
        Action on_414UriTooLong,
        Action on_414RequestUriTooLong,
        Action on_415UnsupportedMediaType,
        Action on_416RequestedRangeNotSatisfiable,
        Action on_417ExpectationFailed,
        Action on_418IAmATeapot,
        Action on_419InsufficientSpaceOnResource,
        Action on_420MethodFailure,
        Action on_421DestinationLocked,
        Action on_422UnprocessableEntity,
        Action on_423Locked,
        Action on_424FailedDependency,
        Action on_425TooEarly,
        Action on_426UpgradeRequired,
        Action on_428PreconditionRequired,
        Action on_429TooManyRequests,
        Action on_431RequestHeaderFieldsTooLarge,
        Action on_451UnavailableForLegalReasons,
        Action on_500InternalServerError,
        Action on_501NotImplemented,
        Action on_502BadGateway,
        Action on_503ServiceUnavailable,
        Action on_504GatewayTimeout,
        Action on_505HttpVersionNotSupported,
        Action on_506VariantAlsoNegotiates,
        Action on_507InsufficientStorage,
        Action on_508LoopDetected,
        Action on_509BandwidthLimitExceeded,
        Action on_510NotExtended,
        Action on_511NetworkAuthenticationRequired,
        Action<string> otherwise)
    {
        if (this == _100Continue) on_100Continue();
        else if (this == _101SwitchingProtocols) on_101SwitchingProtocols();
        else if (this == _102Processing) on_102Processing();
        else if (this == _103Checkpoint) on_103Checkpoint();
        else if (this == _200Ok) on_200Ok();
        else if (this == _201Created) on_201Created();
        else if (this == _202Accepted) on_202Accepted();
        else if (this == _203NonAuthoritativeInformation) on_203NonAuthoritativeInformation();
        else if (this == _204NoContent) on_204NoContent();
        else if (this == _205ResetContent) on_205ResetContent();
        else if (this == _206PartialContent) on_206PartialContent();
        else if (this == _207MultiStatus) on_207MultiStatus();
        else if (this == _208AlreadyReported) on_208AlreadyReported();
        else if (this == _226ImUsed) on_226ImUsed();
        else if (this == _300MultipleChoices) on_300MultipleChoices();
        else if (this == _301MovedPermanently) on_301MovedPermanently();
        else if (this == _302Found) on_302Found();
        else if (this == _302MovedTemporarily) on_302MovedTemporarily();
        else if (this == _303SeeOther) on_303SeeOther();
        else if (this == _304NotModified) on_304NotModified();
        else if (this == _305UseProxy) on_305UseProxy();
        else if (this == _307TemporaryRedirect) on_307TemporaryRedirect();
        else if (this == _308PermanentRedirect) on_308PermanentRedirect();
        else if (this == _400BadRequest) on_400BadRequest();
        else if (this == _401Unauthorized) on_401Unauthorized();
        else if (this == _402PaymentRequired) on_402PaymentRequired();
        else if (this == _403Forbidden) on_403Forbidden();
        else if (this == _404NotFound) on_404NotFound();
        else if (this == _405MethodNotAllowed) on_405MethodNotAllowed();
        else if (this == _406NotAcceptable) on_406NotAcceptable();
        else if (this == _407ProxyAuthenticationRequired) on_407ProxyAuthenticationRequired();
        else if (this == _408RequestTimeout) on_408RequestTimeout();
        else if (this == _409Conflict) on_409Conflict();
        else if (this == _410Gone) on_410Gone();
        else if (this == _411LengthRequired) on_411LengthRequired();
        else if (this == _412PreconditionFailed) on_412PreconditionFailed();
        else if (this == _413PayloadTooLarge) on_413PayloadTooLarge();
        else if (this == _413RequestEntityTooLarge) on_413RequestEntityTooLarge();
        else if (this == _414UriTooLong) on_414UriTooLong();
        else if (this == _414RequestUriTooLong) on_414RequestUriTooLong();
        else if (this == _415UnsupportedMediaType) on_415UnsupportedMediaType();
        else if (this == _416RequestedRangeNotSatisfiable) on_416RequestedRangeNotSatisfiable();
        else if (this == _417ExpectationFailed) on_417ExpectationFailed();
        else if (this == _418IAmATeapot) on_418IAmATeapot();
        else if (this == _419InsufficientSpaceOnResource) on_419InsufficientSpaceOnResource();
        else if (this == _420MethodFailure) on_420MethodFailure();
        else if (this == _421DestinationLocked) on_421DestinationLocked();
        else if (this == _422UnprocessableEntity) on_422UnprocessableEntity();
        else if (this == _423Locked) on_423Locked();
        else if (this == _424FailedDependency) on_424FailedDependency();
        else if (this == _425TooEarly) on_425TooEarly();
        else if (this == _426UpgradeRequired) on_426UpgradeRequired();
        else if (this == _428PreconditionRequired) on_428PreconditionRequired();
        else if (this == _429TooManyRequests) on_429TooManyRequests();
        else if (this == _431RequestHeaderFieldsTooLarge) on_431RequestHeaderFieldsTooLarge();
        else if (this == _451UnavailableForLegalReasons) on_451UnavailableForLegalReasons();
        else if (this == _500InternalServerError) on_500InternalServerError();
        else if (this == _501NotImplemented) on_501NotImplemented();
        else if (this == _502BadGateway) on_502BadGateway();
        else if (this == _503ServiceUnavailable) on_503ServiceUnavailable();
        else if (this == _504GatewayTimeout) on_504GatewayTimeout();
        else if (this == _505HttpVersionNotSupported) on_505HttpVersionNotSupported();
        else if (this == _506VariantAlsoNegotiates) on_506VariantAlsoNegotiates();
        else if (this == _507InsufficientStorage) on_507InsufficientStorage();
        else if (this == _508LoopDetected) on_508LoopDetected();
        else if (this == _509BandwidthLimitExceeded) on_509BandwidthLimitExceeded();
        else if (this == _510NotExtended) on_510NotExtended();
        else if (this == _511NetworkAuthenticationRequired) on_511NetworkAuthenticationRequired();
        else otherwise(Value);
    }
}
