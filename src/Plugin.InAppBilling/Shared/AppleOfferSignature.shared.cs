namespace Plugin.InAppBilling;

/// <summary>
/// Represents a server-signed Apple promotional offer signature for SKPaymentDiscount.
/// Your server must sign the offer using your App Store Connect subscription key.
/// </summary>
[Preserve(AllMembers = true)]
public record AppleOfferSignature(string KeyId, string Nonce, long Timestamp, string Signature);
