The jar files in the Disambiguation folder:
	-TurkishDisambiguator.jar : The library jar file
	-DisambiguationConsole.jar : The executable jar file that runs with command prompt command "-jar DisambiguationConsole.jar".
	-SupervisedTagger.jar : The executable jar file of SupervisedTagger
	-SupervisedTaggerLibrary.jar : The library file of SupervisedTagger

For disambigution the following files should be in the current folder:
	-PC-KIMMO
	-resources
	-rules
	-SupervisedTagger.conf
	-SupervisedTaggerLibrary.jar
	-TurkishDisambiguator.jar

After performing another tranining the following files sholud be changed:
	-resources/mostLikelyMpForSuffix.txt
	-resources/MostLikelyMpForWord.txt
	-rules/Rules.txt