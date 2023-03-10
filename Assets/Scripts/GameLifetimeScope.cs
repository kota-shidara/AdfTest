using AFolder;
using BFolder;
using CFolder;
using Top;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<AbScript>(Lifetime.Singleton);
        builder.Register<BaScript>(Lifetime.Singleton);
        builder.Register<BbScript>(Lifetime.Singleton);
        builder.Register<CaScript>(Lifetime.Singleton);
        builder.RegisterEntryPoint<AaScript>();
        builder.RegisterEntryPoint<TopScript>();
    }
}
