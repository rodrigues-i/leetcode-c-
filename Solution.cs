public class Solution {
    public bool DetectCapitalUse(string word) {
        bool result = CheckCapital(word);
        return result;
    }

    private bool CheckCapital(string word) {
        string primeriraLetra = word[0].ToString();
        if(word == word.ToUpper()) {
            return true;
        } else if(word == word.ToLower()) {
            return true;
        } else if(word == primeriraLetra.ToUpper() + word.Substring(1).ToLower()) {
            return true;
        } else {
            return false;
        }
    }
}