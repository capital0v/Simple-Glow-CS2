using Capitalov;
using System.Runtime.InteropServices;

namespace SimpleGlow
{
    internal class Feature
    {

        #region Import
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        #endregion

        private MemoryRaider _memory = new MemoryRaider();

        private nint _client;
        private nint _instruction;

        private byte[] _realBytes = new byte[] { 0x32, 0xC0 };

        private bool _glowEnabled;

        private const int VK_F4 = 0x73;

        public Feature()
        {
            try
            {
                _memory.Inject("cs2");
                _client = _memory.GetModuleBase("client.dll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            Start();
        }

        private void Start()
        {
            _instruction = _client + 0x867D50;

            AppDomain.CurrentDomain.ProcessExit += (s, e) =>
            {
                _memory.WriteBytes(_instruction, _realBytes);
            };

            while (true)
            {
                if ((GetAsyncKeyState(VK_F4) & 0x8000) != 0)
                {
                    _glowEnabled = !_glowEnabled;

                    if (_glowEnabled)
                    {
                        _memory.Nop(_instruction, _realBytes.Length);
                    }
                    else
                    {
                        _memory.WriteBytes(_instruction, _realBytes);
                    }

                    Thread.Sleep(300);
                }
                Thread.Sleep(1);
            }
        }
    }
}
