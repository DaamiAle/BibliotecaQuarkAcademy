using Models.src;

namespace Services.src
{
    public class SocioService
    {
        private ProjectContext database;

        public SocioService(ProjectContext context)
        {
            database = context;
        }
    }
}
