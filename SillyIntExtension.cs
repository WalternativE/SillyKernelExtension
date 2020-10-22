using System.Threading.Tasks;
using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Formatting;

namespace SillyKernelExtension
{
    public class SillyIntExtension : IKernelExtension
    {
        public Task OnLoadAsync(Kernel rootKernel)
        {
            RegisterFormatters();

            KernelInvocationContext.Current?.Display("Added a very silly Kernel.", "text/markdown");

            return Task.CompletedTask;
        }

        private void RegisterFormatters()
        {
            Formatter.Register<System.Int32>((value, writer) =>
            {
                writer.Write($"Silly Number: {value}");
            }, "text/plain");
        }
    }
}
