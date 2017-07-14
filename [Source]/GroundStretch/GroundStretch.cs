using Kopernicus;
using Kopernicus.Configuration.ModLoader;


namespace PQSMod_GroundStretch
{
    public class PQSMod_GroundStretch : PQSMod
    {
        public double altitude = 0;
        public double overMult = 1;
        public double underMult = 1;
        double offset;
        public override void OnVertexBuildHeight(PQS.VertexBuildData data)
        {
            offset = data.vertHeight - sphere.radius - altitude;

            offset *= offset > 0 ? overMult : underMult;

            data.vertHeight = sphere.radius + offset;
        }
    }

    [RequireConfigType(ConfigType.Node)]
    public class GroundStretch : ModLoader<PQSMod_GroundStretch>
    {
        // The altitude dividing 'over' from 'under'
        [ParserTarget("altitude", optional = true)]
        private NumericParser<double> altitude
        {
            get { return mod.altitude; }
            set { mod.altitude = value; }
        }

        // Multiplier for the terrain 'over' the altitude
        [ParserTarget("overMult", optional = true)]
        private NumericParser<double> overMult
        {
            get { return mod.overMult; }
            set { mod.overMult = value; }
        }

        // Multiplier for the terrain 'under' the altitude
        [ParserTarget("underMult", optional = true)]
        private NumericParser<double> underMult
        {
            get { return mod.underMult; }
            set { mod.underMult = value; }
        }
    }
}
