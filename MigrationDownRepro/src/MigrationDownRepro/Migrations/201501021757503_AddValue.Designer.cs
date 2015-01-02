using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using MigrationDownRepro;
using System;

namespace MigrationDownRepro.Migrations
{
    [ContextType(typeof(MigrationDownRepro.MyContext))]
    public partial class AddValue : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201501021757503_AddValue";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-rc1-11882";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
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