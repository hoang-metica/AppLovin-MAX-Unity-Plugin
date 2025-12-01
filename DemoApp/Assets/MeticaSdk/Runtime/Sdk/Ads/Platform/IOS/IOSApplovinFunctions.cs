namespace Metica.Ads.IOS
{
    #if UNITY_IOS || UNITY_IPHONE
    internal class IOSApplovinFunctions : MeticaApplovinFunctions
    {
        public bool HasUserConsent()
        {
            return false;
        }

        public bool IsUserConsentSet()
        {
            return false;
        }

        public MaxSdk.ConsentFlowUserGeography GetConsentFlowUserGeography()
        {
            return MaxSdk.ConsentFlowUserGeography.Unknown;
        }
    }
    #endif
}
