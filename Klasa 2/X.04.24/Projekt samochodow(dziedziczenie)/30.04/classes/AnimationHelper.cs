namespace _30._04.classes;

public static class AnimationHelper
{
    public static void ShowProgress(string prefix, string suffix, int delay, int totalSteps)
    {
        for (int i = 0; i <= totalSteps; i++)
        {
            Console.Write($"\r{prefix}[{new string('|', i)}{new string('.', totalSteps - i)}]{suffix} {i * (100 / totalSteps)}%");
            Thread.Sleep(delay);
        }
    }
}