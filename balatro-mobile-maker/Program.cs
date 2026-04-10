namespace balatro_mobile_maker;


/// <summary>
/// Main entry point for the program.
/// </summary>
internal static class Program
{
    public static bool _verboseMode;

    //TODO: Better command line args handling
    public static bool ArgsEnableAccessibleSave = false;
    public static string ArgsGamePath = null;

    /// <summary>
    /// Main entry point of the program
    /// </summary>
    /// <param name="args">Command line arguments</param>
    public static void Main(string[] args)
    {
        //TODO: Better command line args handling
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--enable-external-storage-patch")
                ArgsEnableAccessibleSave = true;
            if (args[i] == "--game-path" && i + 1 < args.Length)
                ArgsGamePath = args[++i];
        }

        View mainView = new View();
        mainView.Begin();
    }
}