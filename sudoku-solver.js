app = {};

app.board = [
	[ 0, 7, 8, 5, 0, 0, 0, 0, 0 ],
	[ 0, 0, 3, 0, 0, 7, 8, 0, 0 ],
	[ 0, 0, 0, 1, 9, 0, 0, 0, 0 ],
	[ 0, 0, 7, 0, 0, 0, 2, 9, 0 ],
	[ 0, 9, 0, 0, 6, 1, 0, 4, 0 ],
	[ 0, 0, 0, 0, 0, 4, 0, 0, 0 ],
	[ 3, 0, 6, 0, 0, 2, 0, 0, 0 ],
	[ 0, 1, 0, 0, 0, 0, 0, 0, 4 ],
	[ 0, 0, 0, 0, 0, 0, 5, 0, 0 ]
];

app.possible = (x, y, n, board) => {
	for(let i=0; i<9; i++)	
		if(board[i][y] == n || board[x][i] == n)
			return false;	
	
	const xbox = parseInt(x/3) *3;
	const ybox = parseInt(y/3) *3;
	for(let i=0; i<3; i++)
		for(let j=0; j<3; j++)
			if(board[xbox+i][ybox+j] === n)
				return false;
	
	return true;
}

app.solve = (board) => {
	for(let x=0; x<9; x++){
		for(let y=0; y<9; y++){
			if(board[x][y] === 0){
				for(let n=1; n<10; n++){
					if(app.possible(x,y,n,board)){
						board[x][y] = n;
						if(app.solve(board))
							return true;
						board[x][y] = 0;	
						
					}
				}
				return false;
			}
		}
	}
	console.log('------------- DONE -------------');
	app.print(board);
	return true;
}
app.print = (board) => {
	for(let i=0; i<9; i++){
		let row = '';
		for(let j=0; j<9; j++)
			row += board[i][j] + '|';
		console.log(row.substring(0,17));
	}
}

app.print(app.board);
app.solve(app.board);
