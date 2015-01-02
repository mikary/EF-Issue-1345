using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using MigrationDownRepro;
using System;

namespace MigrationDownRepro.Migrations
{
    [ContextType(typeof(MigrationDownRepro.MyContext))]
    public class MyContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("MigrationDownRepro.MyData", b =>
                    {
                        b.Property<int>("MyDataId")
                            .GenerateValueOnAdd();
                        b.Property<int>("Value");
                        b.Key("MyDataId");
                    });
                
                return builder.Model;
            }
        }
    }
}