public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        bool result = false;

        IDictionary<int, int> countDict = new Dictionary<int, int>();
        foreach(int i in nums){
            if(countDict.ContainsKey(i)){
                result = true;
            } else {
                countDict.Add(i, 0);
                Console.WriteLine(countDict[i]);
            }

        }

        return result;


    }
}
