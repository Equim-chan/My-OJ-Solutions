// Sum of Intervals
// https://www.codewars.com/kata/sum-of-intervals/javascript
// by Equim on 17-01-17


function sumIntervals(intervals) {
    var ret = 0;

    intervals.sort((a, b) => a[0] > b[0]);
    
    for (var i = 0; i < intervals.length; i++) {
        for (var j = i + 1; j < intervals.length; j++) {
            if (intervals[i] && intervals[j] && intervals[i][1] >= intervals[j][0]) {
                if (intervals[j][1] > intervals[i][1]) {
                    intervals[i][1] = intervals[j][1];
                }
                if (intervals[j][0] < intervals[i][0]) {
                    intervals[i][0] = intervals[j][0];
                }
                delete intervals[j];
            }
        };
    }
    
    for (var i = 0; i < intervals.length; i++) {
        if (intervals[i]) {
            ret += intervals[i][1] - intervals[i][0];
        }
    }
    return ret;
}