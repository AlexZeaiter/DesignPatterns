using DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatternsClasses.FactoryClasses.DocumentFactory.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
        }
    }
}
