using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WpfDemo
{
    public class TasksVoiceSynthesis : IDisposable
    {
        public string Text { get; set; } = "";
          
        public string PrefferedVoice { get; set; } = "Microsoft David Desktop";





        // Initialize a new instance of the Speech Synthesizer.
        private SpeechSynthesizer synth = new SpeechSynthesizer();



        public TasksVoiceSynthesis(string text, string PrefferedVoice)
        {
            
            {
                this.Text = text;
                this.PrefferedVoice = PrefferedVoice;
            }
        }
        

        public string CurrentVoice()
        {
            
                    
                    string CurrentVoice = synth.Voice.Name;
                    return CurrentVoice;
                    
                
        }
        public List<string> Voices
        {
            get
            {
                //Initialize string array
                List<string> voicesList = new List<string>();
                //Querry all installed voices
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    voicesList.Add(info.Name);
                }
                //return string list with all voices
                return voicesList;
            }
        }        
        public  void PlayTasks()
        {

            

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();
            // Create a prompt from a string.  
            Prompt voice = new Prompt(Text);
            // Speak a string.  
            synth.SpeakAsync(voice);            
        }
        public void PlayTasks(string PrefferedVoice)
        {
        
            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();
            // Create a prompt from a string.  
            Prompt voice = new Prompt(Text);
            //change Voice
            synth.SelectVoice(PrefferedVoice);
            // Speak a string.  
            synth.SpeakAsync(voice);
            //synth.Speak(voice);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~TasksVoiceSynthesis() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
/* 
   private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {            
            TasksVoiceSynthesis taskObj = new TasksVoiceSynthesis($"{ Text.Text}") ;
            //taskObj.text = $"{ Text.Text}";
            taskObj.PlayTasks();
        }

    public void List<string> ReturnInstalledVoices()
        {
            // Initialize a new instance of the Speech Synthesizer.
            SpeechSynthesizer synth1 = new SpeechSynthesizer();
            //Initialize string array
            List<string> voicesList = new List<string>();
            foreach (InstalledVoice voice in synth1.GetInstalledVoices())            
            {
                VoiceInfo info = voice.VoiceInfo;
                voicesList.Add(info.Name);
            }
            return voicesList;
        }

     public static List<string> ReturnInstalledVoices()
        {
            // Initialize a new instance of the Speech Synthesizer.
            SpeechSynthesizer synth1 = new SpeechSynthesizer();
            //Initialize string array
            List<string> voicesList = new List<string>();
            foreach (InstalledVoice voice in synth1.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                voicesList.Add(info.Name);
            }
            return voicesList;
        }
        */


