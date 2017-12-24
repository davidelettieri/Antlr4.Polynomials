// Generated from c:\Users\david\Documents\Progetti\Antlr4\Polinomi\Polinomi.g4 by ANTLR 4.7
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class PolinomiParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, NUM=3, VAR=4, SIGN=5, WS=6;
	public static final int
		RULE_polinomio = 0, RULE_monomio = 1;
	public static final String[] ruleNames = {
		"polinomio", "monomio"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'*'", "'^'", null, null, null, "' '"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, "NUM", "VAR", "SIGN", "WS"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Polinomi.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public PolinomiParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class PolinomioContext extends ParserRuleContext {
		public PolinomioContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_polinomio; }
	 
		public PolinomioContext() { }
		public void copyFrom(PolinomioContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class SommaMonomiContext extends PolinomioContext {
		public List<TerminalNode> SIGN() { return getTokens(PolinomiParser.SIGN); }
		public TerminalNode SIGN(int i) {
			return getToken(PolinomiParser.SIGN, i);
		}
		public List<MonomioContext> monomio() {
			return getRuleContexts(MonomioContext.class);
		}
		public MonomioContext monomio(int i) {
			return getRuleContext(MonomioContext.class,i);
		}
		public SommaMonomiContext(PolinomioContext ctx) { copyFrom(ctx); }
	}
	public static class IstanzaMonomioContext extends PolinomioContext {
		public MonomioContext monomio() {
			return getRuleContext(MonomioContext.class,0);
		}
		public IstanzaMonomioContext(PolinomioContext ctx) { copyFrom(ctx); }
	}

	public final PolinomioContext polinomio() throws RecognitionException {
		PolinomioContext _localctx = new PolinomioContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_polinomio);
		int _la;
		try {
			setState(11);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case SIGN:
				_localctx = new SommaMonomiContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(6); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(4);
					match(SIGN);
					setState(5);
					monomio();
					}
					}
					setState(8); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==SIGN );
				}
				break;
			case T__0:
			case NUM:
			case VAR:
				_localctx = new IstanzaMonomioContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(10);
				monomio();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MonomioContext extends ParserRuleContext {
		public TerminalNode VAR() { return getToken(PolinomiParser.VAR, 0); }
		public List<TerminalNode> NUM() { return getTokens(PolinomiParser.NUM); }
		public TerminalNode NUM(int i) {
			return getToken(PolinomiParser.NUM, i);
		}
		public MonomioContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_monomio; }
	}

	public final MonomioContext monomio() throws RecognitionException {
		MonomioContext _localctx = new MonomioContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_monomio);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(14);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==NUM) {
				{
				setState(13);
				match(NUM);
				}
			}

			setState(17);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(16);
				match(T__0);
				}
			}

			setState(19);
			match(VAR);
			setState(20);
			match(T__1);
			setState(21);
			match(NUM);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\b\32\4\2\t\2\4\3"+
		"\t\3\3\2\3\2\6\2\t\n\2\r\2\16\2\n\3\2\5\2\16\n\2\3\3\5\3\21\n\3\3\3\5"+
		"\3\24\n\3\3\3\3\3\3\3\3\3\3\3\2\2\4\2\4\2\2\2\33\2\r\3\2\2\2\4\20\3\2"+
		"\2\2\6\7\7\7\2\2\7\t\5\4\3\2\b\6\3\2\2\2\t\n\3\2\2\2\n\b\3\2\2\2\n\13"+
		"\3\2\2\2\13\16\3\2\2\2\f\16\5\4\3\2\r\b\3\2\2\2\r\f\3\2\2\2\16\3\3\2\2"+
		"\2\17\21\7\5\2\2\20\17\3\2\2\2\20\21\3\2\2\2\21\23\3\2\2\2\22\24\7\3\2"+
		"\2\23\22\3\2\2\2\23\24\3\2\2\2\24\25\3\2\2\2\25\26\7\6\2\2\26\27\7\4\2"+
		"\2\27\30\7\5\2\2\30\5\3\2\2\2\6\n\r\20\23";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}