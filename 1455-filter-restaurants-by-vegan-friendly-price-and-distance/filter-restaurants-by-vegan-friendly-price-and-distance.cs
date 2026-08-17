public class Solution {
    public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance) {
        return restaurants.Where(r => (veganFriendly==0 || r[2]==1) && r[3] <= maxPrice && r[4] <= maxDistance)
        .OrderByDescending(r => r[1]).ThenByDescending(r => r[0])
        .Select(r => r[0]).ToList();
    }
}