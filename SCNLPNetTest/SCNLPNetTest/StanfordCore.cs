using System;
using System.Collections.Generic;
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

        public List<sWord> getAnnotatedWords(string input)
        {
            List<sWord> list = new List<sWord>();
            foreach (var item in getAnnotation(input).Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None))
            {
                if (item.Length > 1)
                {
                    string[] ws = item.Split('\t');
                    list.Add(new sWord(ws[1], ws[2], ws[3]));
                }
            }
            return list;
        }
        public class sWord
        {
            public string word;
            public string lemma;
            public string POS;

            public sWord(string word, string lemma, string POS)
            {
                this.word = word;
                this.lemma = lemma;
                this.POS = POS;
            }
        }

    }
}
