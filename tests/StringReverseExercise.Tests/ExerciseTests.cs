namespace StringReverseExercise.Tests;

public class ExerciseTests
{
	[Fact]
	public void Cc_StringReverser()
	{
		// act
		var c = new StringReverser();

		// assert
		Assert.NotNull(c);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "do! I banana? pear, apple, fruits: these of any like you Do developer. Hello")]
	[InlineData("Hello developer. I like an apple. Do you like an apple too? Do you like an apple too?", "too? apple an like you Do too? apple an like you Do apple. an like I developer. Hello")]
	[InlineData("Hello World!", "World! Hello")]


	public void Opdracht1_WithText_ReturnsReversedText(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od")]
	[InlineData("Hello developer. I like an apple. Do you like an apple too? Do you like an apple too?", "olleH .repoleved I ekil na .elppa oD uoy ekil na elppa ?oot oD uoy ekil na elppa ?oot")]
	[InlineData("Hello World!", "olleH !dlroW")]
	
	public void Opdracht2_WithText_ReturnsReversedWords(string s2, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string? result = c.Exercise2(s2);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "OLLEh .REPOLEVED Od UOY EKIL YNA FO ESEHT :STIURF ,ELPPA ,RAEP ?ANANAB i !OD")]
	[InlineData("Hello developer. I like an apple. Do you like an apple too? Do you like an apple too?", "OLLEh .REPOLEVED i EKIL NA .ELPPA Od UOY EKIL NA ELPPA ?OOT Od UOY EKIL NA ELPPA ?OOT")]
	[InlineData("Hello World!", "OLLEh !DLROw")]
	public void Opdracht3_1_WithText_ReturnsReversedCasing(string s31, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string? result = c.Exercise31(s31);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "Olleh .repoleved Od Uoy Ekil Yna Fo Eseht :stiurf ,elppa ,raep ?ananab I !od")]
	[InlineData("Hello developer. I like an apple. Do you like an apple too? Do you like an apple too?", "Olleh .repoleved I Ekil Na .elppa Od Uoy Ekil Na Elppa ?oot Od Uoy Ekil Na Elppa ?oot")]
	[InlineData("Hello World!", "Olleh !dlrow")]
	public void Opdracht3_2_WithText_ReturnsReversedEachWordCapitalized(string s32, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string? result = c.Exercise32(s32);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "Olleh .Repoleved od uoy ekil yna fo eseht :stiurf ,elppa ,raep ?Ananab i !Od")]
	[InlineData("Hello developer. I like an apple. Do you like an apple too? Do you like an apple too?", "Olleh .Repoleved i ekil na .Elppa od uoy ekil na elppa ?Oot od uoy ekil na elppa ?Oot")]
	[InlineData("Hello World!", "Olleh !Dlrow")]
	public void Opdracht3_3_WithText_ReturnsReversedEachFirstWordCapitalized(string s33, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string? result = c.Exercise33(s33);

		//assert
		Assert.Equal(expected, result);
	}
}