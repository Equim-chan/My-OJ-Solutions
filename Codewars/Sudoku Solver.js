// Sudoku Solver
// https://www.codewars.com/kata/sudoku-solver
// by Equim on 16-12-31

function sudoku(puzzle) {
    var findNext = (line, col) => {
        while (line <= 8) {
            while (++col <= 8) {
                if (puzzle[line][col] === 0)
                    return [line, col];
            }
            line++;
            col = -1;
        }
        return undefined;
    };
    
    var valid = (line, col, i) => {
        for (var k = 0; k < 9; k++) {
            if (puzzle[line][k] === i || puzzle[k][col] === i)
                return false;
        }
        
        var blockY = line - line % 3;
        var blockX = col - col % 3;
        for (var k = 0; k < 3; k++) {
            for (var j = 0; j < 3; j++) {
                if (puzzle[blockY + k][blockX + j] === i)
                    return false;
            }
        }
        
        return true;
    };

    var DFS = (line, col) => {
        for (var i = 1; i <= 9; i++) {
            if (valid(line, col, i)) {
                puzzle[line][col] = i;
                var pos = findNext(line, col);
                if (pos === undefined || DFS(pos[0], pos[1]))
                    return true;
                puzzle[line][col] = 0;
            }
        }
        return false;
    };
    
    var pos = findNext(0, -1);
    if (pos !== undefined)
        DFS(pos[0], pos[1]);
    return puzzle;
}