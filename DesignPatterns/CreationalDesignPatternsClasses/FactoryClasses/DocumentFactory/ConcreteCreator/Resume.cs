using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
