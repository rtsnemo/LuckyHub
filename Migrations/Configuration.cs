namespace StyleHub.Migrations
{
    using StyleHub.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StyleHub.Data.StyleHubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StyleHub.Data.StyleHubContext";
        }

        protected override void Seed(StyleHub.Data.StyleHubContext context)
        {
            var ukrPoshtaOption = new DeliveryOption { DeliveryName = "УкрПошта" };
            var novaPoshtaOption = new DeliveryOption { DeliveryName = "Нова Пошта" };

            context.DeliveryOptions.AddOrUpdate(
                d => d.DeliveryName,
                ukrPoshtaOption,
                novaPoshtaOption
            );
            context.SaveChanges();
        }
    }
}
