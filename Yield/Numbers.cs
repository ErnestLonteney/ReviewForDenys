using System.Collections;


namespace Yield
{
    public class Numbers
    {
        public static IEnumerable Number(int[] arr)
        {
            if (arr == null)
            {
                yield break;
            }

            foreach (int positive in arr)
            {
                if(positive < 0)
                {
                    yield return positive;
                }
                
            }
        }
    }
}
