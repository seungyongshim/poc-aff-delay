using LanguageExt;
using static LanguageExt.Prelude;

var q = from _1 in Task.Delay(1000).ToUnit().ToAff()
        from _2 in Eff(() =>
        {
            Console.WriteLine($"{DateTime.Now:R} : Hello, World!");
            return unit;
        })
        
        select unit;

await q.Repeat().Run();





