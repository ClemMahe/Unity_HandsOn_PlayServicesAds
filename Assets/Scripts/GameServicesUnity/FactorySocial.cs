namespace GameServicesUnity
{
    public static class FactorySocial
    {
        public static ISocialServices mInstance;

        public static ISocialServices GetSocialServices(){
            if(mInstance==null){
                #if UNITY_ANDROID
                    mInstance = new SocialAndroid();
                #else 
                    mInstance = new SocialMacPc();
                #endif
            }
            return mInstance;
        }
    }
}