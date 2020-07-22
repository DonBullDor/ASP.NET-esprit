using System.Data.Entity;

namespace Solution.Data
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MaChaine")
        {

        }
        //les DbSet<> ....
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Configurations.Add(.....);
            modelBuilder.Conventions.Add(.....);*/

        }
    }
}
