using AVFoundation;
using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Songwriter3.Classes
{
    class AudioRecorder
    {
        private AVAudioRecorder _recorder;
        private NSError _error;
        private NSUrl _url;
        private NSDictionary _settings;

        private string _songName;
        private bool _audioSessionCreated;

        private string _audioFilePath;
        private string _audioFileName;


        private void activateAudioSession()
        {
            var audioSession = AVAudioSession.SharedInstance();
            var err = audioSession.SetCategory(AVAudioSessionCategory.PlayAndRecord);
            if (err != null)
            {
                Console.WriteLine("audioSession: {0}", err);
                _audioSessionCreated =  false;
            }
            err = audioSession.SetActive(true);
            if (err != null)
            {
                Console.WriteLine("audioSession: {0}", err);
                _audioSessionCreated =  false;
            }

            _audioSessionCreated =  true;
        }
        public void DeactivateAudioSession()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetActive(false);
        }
        public void ReactivateAudioSession()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetActive(true);
        }
        public AudioRecorder(string songName)
        {
            _songName = songName;
            activateAudioSession();
            prepareToRecord();
        }
        private void prepareToRecord()
        {
            if (_audioSessionCreated)
            {
                //Declare string for application temp path and tack on the file extension
                _audioFileName = string.Format("{0}{1}.wav", _songName, DateTime.Now.ToString("yyyyMMddHHmmss"));
                _audioFilePath = Path.Combine(Path.GetTempPath(), _audioFileName);

                Console.WriteLine("Audio File Path: " + _audioFilePath);

                _url = NSUrl.FromFilename(_audioFilePath);
                //set up the NSObject Array of values that will be combined with the keys to make the NSDictionary
                NSObject[] values = new NSObject[]
                {
    NSNumber.FromFloat (44100.0f), //Sample Rate
    NSNumber.FromInt32 ((int)AudioToolbox.AudioFormatType.LinearPCM), //AVFormat
    NSNumber.FromInt32 (2), //Channels
    NSNumber.FromInt32 (16), //PCMBitDepth
    NSNumber.FromBoolean (false), //IsBigEndianKey
    NSNumber.FromBoolean (false) //IsFloatKey
                };

                //Set up the NSObject Array of keys that will be combined with the values to make the NSDictionary
                NSObject[] keys = new NSObject[]
                {
    AVAudioSettings.AVSampleRateKey,
    AVAudioSettings.AVFormatIDKey,
    AVAudioSettings.AVNumberOfChannelsKey,
    AVAudioSettings.AVLinearPCMBitDepthKey,
    AVAudioSettings.AVLinearPCMIsBigEndianKey,
    AVAudioSettings.AVLinearPCMIsFloatKey
                };

                //Set Settings with the Values and Keys to create the NSDictionary
                _settings = NSDictionary.FromObjectsAndKeys(values, keys);

                //Set recorder parameters
                _recorder = AVAudioRecorder.Create(_url, new AudioSettings(_settings), out _error);

                //Set Recorder to Prepare To Record
                _recorder.PrepareToRecord();
            }
        }
        public void StartRecording()
        {
            if (_audioSessionCreated)
            {
                _recorder.Record();
            }
        }
        public Recording StopRecording()
        {
            _recorder.Stop();
            Recording r = new Recording();
            r.CreationTime = DateTime.Now;
            r.FileName = _audioFileName;
            r.FilePath = _audioFilePath;
            return r;
        }

    }
}
