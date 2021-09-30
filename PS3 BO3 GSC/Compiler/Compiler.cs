using TreyarchCompiler.Games;
using TreyarchCompiler.Utilities;

namespace TreyarchCompiler
{
    //NOTE: this class system will no longer work as of bo3, because each platform has unique opcodes.
    public class Compiler
    {
        public static CompiledCode Compile(bool uset8masking, string code, string path = "")
        {
            return new GSCCompiler(code, path, false)?.Compile();
        }
    }
}