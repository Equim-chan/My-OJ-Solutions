// 37. Sudoku Solver
// https://leetcode.com/problems/sudoku-solver/
// by Equim on 16-12-31

/**
 * @param {character[][]} board
 * @return {void} Do not return anything, modify board in-place instead.
 */
var solveSudoku = function(board) {
    const findNext = (line, col) => {
        while (line <= 8) {
            while (++col <= 8) {
                if (board[line][col] == '.')
                    return [line, col];
            }
            line++;
            col = -1;
        }
        return undefined;
    };
    
    const valid = (line, col, i) => {
        for (var k = 0; k < 9; k++) {
            if (board[line][k] == i || board[k][col] == i)
                return false;
        }
        
        var blockY = line - line % 3;
        var blockX = col - col % 3;
        for (var k = 0; k < 3; k++) {
            for (var j = 0; j < 3; j++) {
                if (board[blockY + k][blockX + j] == i)
                    return false;
            }
        }
        
        return true;
    };

    const DFS = (line, col) => {
        for (var i = '1'; i <= '9'; i++) {
            if (valid(line, col, i)) {
                board[line][col] = i;
                var pos = findNext(line, col);
                if (pos === undefined || DFS(pos[0], pos[1]))
                    return true;
                board[line][col] = '.';
            }
        }
        return false;
    };
    
    var pos = findNext(0, -1);
    if (pos !== undefined)
        DFS(pos[0], pos[1]);
};