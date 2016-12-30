// Did I Finish my Sudoku?
// https://www.codewars.com/kata/did-i-finish-my-sudoku/
// by Equim on 16-12-31

function doneOrNot(board) {
    var nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    var match = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
    
    for (var lines = 0; lines < 9; lines++) {
        var test = new Array(nums);
        for (var item = 0; item < 9; item++) {
            if (test[board[lines][item]] == 0) return "Try again!";
            test[board[lines][item]] = 0;
        }
    }
    
    for (var cols = 0; cols < 9; cols++) {
        var test = new Array(nums);
        for (var item = 0; item < 9; item++) {
            if (test[board[item][cols]] == 0) return "Try again!";
            test[board[item][cols]] = 0;
        }
    }
    
    for (var boxX = 0; boxX < 9; boxX += 3) {
        for (var boxY = 0; boxY < 9; boxY += 3) {
            var test = new Array(nums);
            for (var x = boxX; x < 3; x++) {
                for (var y = boxY; y < 3; y++) {
                    if (test[board[x][y]] == 0) return "Try again!";
                    test[board[x][y]] = 0;
                }
            }
        }
    }
    
    return "Finished!";
}