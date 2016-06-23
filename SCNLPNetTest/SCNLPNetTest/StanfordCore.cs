using System; 
using java.io;
using edu.stanford.nlp.pipeline;
using System.IO;

namespace SCNLPNetTest
{
    class StanfordCore
    {
        StanfordCoreNLP pipeline;
        public StanfordCore(string jarRoot = @"..\..\models")
        {
            var props = new java.util.Properties();
            props.setProperty("annotators", "tokenize, ssplit, pos, lemma");
            // props.setProperty("ner.useSUTime", "0"); 
            var curDir = Environment.CurrentDirectory;
            Directory.SetCurrentDirectory(jarRoot);
            pipeline = new StanfordCoreNLP(props);
            Directory.SetCurrentDirectory(curDir);
        }
        public string getAnnotation(string input)
        {
            Annotation annotation = new Annotation(input);
            pipeline.annotate(annotation);

            string result = "";
            using (var stream = new ByteArrayOutputStream())
            {
                pipeline.conllPrint(annotation, new PrintWriter(stream));
                result += stream.toString();
                stream.close();
            }
            return result;
        }

        public string getLemmas(string input)
        {
            string lemmas = "";
            foreach (var item in getAnnotation(input).Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None))
            {
                if (item.Length > 1)
                {
                    string[] ws = item.Split('\t');
                    if(ws.Length>2)
                        lemmas+=ws[2] +"|"+ws[3]+" ";
                }
            }
            return lemmas.Trim();
        }
 

    }
}
