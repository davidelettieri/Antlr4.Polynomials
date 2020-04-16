grammar Polynomial;

polynomial      : (SIGN? monomial)(SIGN monomial)*				#monomialSum; 
monomial        : NUM? '*'? (VAR (POWER NUM)?)+					#realMonomial
				| NUM											#const;
monom			: (VAR (POWER NUM)?)+							;

NUM             : [0-9]+;
VAR             : [a-z];
SIGN            : '+' | '-';
POWER			: '^';
WS              : ' ' -> skip;