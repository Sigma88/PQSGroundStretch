using System.Resources;


namespace PQSMod_GroundStretch
{
    internal class Resources
    {
        private static ResourceManager resourceMan;

        internal Resources()
        {
        }

        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager temp = new ResourceManager("PQSMod_GroundStretch.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        internal static byte[] SigmaGSLS_1
        {
            get
            {
                object obj = ResourceManager.GetObject("SigmaGSLS_1");
                return ((byte[])(obj));
            }
        }
    }
}
