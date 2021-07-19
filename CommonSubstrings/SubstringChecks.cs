using System;

namespace CommonSubstrings
{
    public class SubstringChecks
    {
	    public bool HasCommonSubstring(string first, string second)
	    {
		    //Eliminate bad input
		    //Eliminate bad input
		    if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(second))
			    return false;
		    
		    first = first.ToLower().Trim();
		    second = second.ToLower().Trim();
            
            //Groom inputs
		    first = first.ToLower().Trim();
		    second = second.ToLower().Trim();
       
		    //Search for first common char, if found return
        	var matrix = new int[first.Length, second.Length];
        	for (var f = 0; f < first.Length; f++)
        		for (var s = 0; s < second.Length; s++)
	                if (first[f] == second[s]) return true;
            return false;
	    }        
	    
        public int LongestCommonSubstring(string first, string second)
        {
		    //Eliminate bad input
		    if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(second))
			    return 0;
		    
		    first = first.ToLower().Trim();
		    second = second.ToLower().Trim();
		    
        	var matrix = new int[first.Length, second.Length];
            var maxSubstrLen = 0;
        
        	for (var f = 0; f < first.Length; f++)
        		for (var s = 0; s < second.Length; s++)
        			if (first[f] != second[s]) matrix[f, s] = 0;
                    else
                    {
	                    if ((f == 0) || (s == 0)) matrix[f, s] = 1;
	                    else matrix[f, s] = 1 + matrix[f - 1, s - 1];
	                    if (matrix[f, s] > maxSubstrLen) maxSubstrLen = matrix[f, s];
                    }
            
            return maxSubstrLen;
        }
    }
}