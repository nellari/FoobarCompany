using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class OperationRegistryImpl : IOperationRegistry
    {
        /// <summary>
        /// Contains a mapping of the defined IOperation classes
        /// </summary>
        private readonly static Dictionary<string, Type> operationDict;

        public string[] GetAllSymbols => operationDict.Keys.ToArray<string>();

        /// <summary>
        /// Return an IOperation type based on the specified symbol parameter 
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="firstArg"></param>
        /// <param name="secondArg"></param>
        /// <returns></returns>
        public IOperation CreateOperation(string symbol, int firstArg, int secondArg)
        {
            if (!OperationRegistryImpl.operationDict.ContainsKey(symbol))
                throw new ArgumentException("Invalid operation symbol (" + symbol + ")");
            return (IOperation)Activator.CreateInstance(OperationRegistryImpl.operationDict[symbol], firstArg, secondArg);
        }

        /// <summary>
        /// Reflection to build a dictionary with the available operation
        /// </summary>
        static OperationRegistryImpl()
        {
            operationDict = new Dictionary<string, Type>();
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IOperation).IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);
            //In case of empty symbol a sum is performed
            operationDict.Add(string.Empty, typeof(Sum));
            foreach (var t in types)
                operationDict.Add(((IOperation)Activator.CreateInstance(t, 0, 1)).Symbol, t);
        }
    }
}
