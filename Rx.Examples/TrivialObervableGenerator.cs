using System;
using System.Collections;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace Rx.Examples
{
    public class TrivialObervableGenerator
    {
        readonly IDictionary<string,string> _dictionary = new Dictionary<string, string>();

        public TrivialObervableGenerator()
        {   
            foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
            {
                _dictionary.Add(environmentVariable.Key.ToString(), environmentVariable.Value.ToString());
            }
        }

        public IObservable<KeyValuePair<string, string>> GetEnvironmentalVariables()
        {
            var tick = Observable.Timer(TimeSpan.FromMilliseconds(0), TimeSpan.FromMilliseconds(50));

            var environmentalVariablesObservable = _dictionary
                .ToObservable()
                .Select(m => new KeyValuePair<string,string>(m.Key,m.Value))
                .Distinct()
                .Zip(tick, (res, _) => res);

            return environmentalVariablesObservable;
        }
    }
}
