grammar Polynomial;

polynomial      : (SIGN? monomial)(SIGN monomial)*				#monomialSum; 
monomial        : NUM? '*'? VAR ('^' NUM)?						#realMonomial
				| NUM											#const;

NUM             : [0-9]+;
VAR             : [a-z];
SIGN            : '+' | '-';
WS              : ' ' -> skip;