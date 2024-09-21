var app = new Vue({
    el: '#app',
    data: {
        sovedBoard: null,
        board: [
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0],
            // [0,0,0,0,0,0,0,0,0]
            [ 0, 0, 1, 2, 0, 3, 4, 0, 0 ],
            [ 0, 0, 0, 6, 0, 7, 0, 0, 0 ],
            [ 5, 0, 0, 0, 0, 0, 0, 0, 3 ],
            [ 3, 7, 0, 0, 0, 0, 0, 8, 1 ],
            [ 0, 0, 0, 0, 0, 0, 0, 0, 0 ],
            [ 6, 2, 0, 0, 0, 0, 0, 3, 7 ],
            [ 1, 0, 0, 0, 0, 0, 0, 0, 8 ],
            [ 0, 0, 0, 8, 0, 5, 0, 0, 0 ],
            [ 0, 0, 6, 4, 0, 2, 5, 0, 0 ]
        ],
        iteration: 0
    },
    methods: {
        solveBoard: () => {
            let board = [];
            for(let x = 0; x < 9; x++) {
                board[x] = [];
                for(let y = 0; y < 9 ; y++){
                    board[x][y] = this.app.board[x][y];
                }
            }
            this.app.solve(board);
        },
        solve: (board) => {
            this.app.iteration++;
            for(let x = 0; x < 9; x++) {
                for(let y = 0; y < 9 ; y++){
                    if(board[x][y] === 0) {
                        for(let n = 1; n<10 ; n++) {
                            if(this.app.possible(x, y, n, board)) {
                                board[x][y] = n;
                                if(this.app.solve(board)){
                                    return true;
                                }
                                board[x][y] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            this.app.sovedBoard = board;
            return true;
        },
        possible: (x,y,n, board) => {
            for (let i = 0; i < 9; i++) {
                if (board[x][i] === n || board[i][y] === n) return false;
            }
            for(let xBox = Math.floor(x/3) * 3; xBox < Math.floor(x/3) *3 +3 ; xBox ++){
                for(let yBox = Math.floor(y/3) * 3; yBox < Math.floor(y/3) *3 +3 ; yBox ++){
                    if (board[xBox][yBox] === n) return false;
                }
            }
            return true;
        },
        sleep: (milliseconds) => {
            let start = new Date().getTime();
            for (var i = 0; i < 1e7; i++) {
                if ((new Date().getTime() - start) > milliseconds){
                break;
                }
            }
        }
    }
  })




// let puzzle1 = [
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0]];
// let puzzle = [
//     [0,0,0,5,0,0,0,0,0],
//     [0,0,5,0,0,9,2,4,0],
//     [0,0,6,0,0,0,0,7,0],    
//     [0,0,0,0,2,0,0,2,0],
//     [0,0,7,0,0,4,1,0,0],
//     [8,0,0,3,9,0,0,0,0],
//     [4,0,3,0,0,0,0,0,6],
//     [0,0,0,4,0,0,0,0,7],
//     [0,8,0,0,6,0,0,0,2]];
// let expertPuzzle = [
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],    
//     [3,8,4,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,0],
//     [0,0,0,0,0,0,0,0,2]];
// print();
//console.log(sudokuSolver(initPuzzle)); 

