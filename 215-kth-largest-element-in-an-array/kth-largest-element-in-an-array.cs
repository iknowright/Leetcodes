public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> heap=new();

        foreach(int num in nums) {
            heap.Enqueue(num, num);
            if(heap.Count>k) heap.Dequeue();
        }
        return heap.Peek();
    }
}