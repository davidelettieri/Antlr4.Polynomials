grammar Polynomial;

expr			: expr PLUS expr					#add
				| expr MINUS expr					#subtract
				| expr PROD? expr					#prod
				| expr POWER OP? expr CP?			#power
				| VAR								#var
				| NUM								#const;

CP				: ')';
OP				: '(';
NUM             : [0-9]+;
VAR             : [a-z];
PLUS            : '+';
MINUS			: '-';
PROD			: '*';
POWER			: '^';
WS              : ' ' -> skip;