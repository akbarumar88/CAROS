using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class dataTarget : MonoBehaviour {

        public Transform TextTargetName;
        public Transform TextDescription;
        public Button btnPlay;
        public Button btnStop;
        public AudioSource ajapanSurender, arengasdengklok, amalamProklamasi, aproklamasi, amerdeka, asaron;
        public Animator microsope, telescope, camera, glasses, magnifying_glass, platter, spindle, rw_arm, actuator, logic_board, voc_coin, voc_army, proklamasi2, monas, indonesian_army, rengasdengklok, malam_proklamasi, proklamasi, merdeka, japan_surender, silat, baju_adat, joglo, saron, batik;

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                //If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie
                if (name == "Logic_Board")
                {
                    TextTargetName.GetComponent<Text>().text = "Logic Board";
                    TextDescription.GetComponent<Text>().text = "A logicboard is the main printed circuit board (PCB) found in general purpose microcomputers and other expandable systems";
                    btnPlay.onClick.AddListener(() => playLogicBoard());
                    btnStop.onClick.AddListener(() => stopLogicBoard());
                }
                else if(name == "Platter"){
                    TextTargetName.GetComponent<Text>().text = "Platter";
                    TextDescription.GetComponent<Text>().text = "A hard disk drive platter (or disk) is the circular disk on which magnetic data is stored in a hard disk drive";
                    btnPlay.onClick.AddListener(() => playPlatter());
                    btnStop.onClick.AddListener(() => stopPlatter());
                }
                else if (name == "Spindle")
                {
                    TextTargetName.GetComponent<Text>().text = "Spindle";
                    TextDescription.GetComponent<Text>().text = "A spindle is a shaft that holds rotating hard disk drive (HDD) platters in place. The term is also often used to refer to a single HDD";
                    btnPlay.onClick.AddListener(() => playSpindle());
                    btnStop.onClick.AddListener(() => stopSpindle());
                }
                else if (name == "RW_Arm")
                {
                    TextTargetName.GetComponent<Text>().text = "Read Write Arm";
                    TextDescription.GetComponent<Text>().text = "Disk read/write heads are the small parts of a disk drive which move above the disk platter and transform the platter's magnetic field into electrical current or, vice versa, transform electrical current into magnetic field";
                    btnPlay.onClick.AddListener(() => playArm());
                    btnStop.onClick.AddListener(() => stopArm());
                }
                else if (name == "Actuator")
                {
                    TextTargetName.GetComponent<Text>().text = "Actuator";
                    TextDescription.GetComponent<Text>().text = "An actuator is a component of a machine that is responsible for moving and controlling a mechanism or system, for example by opening a valve. In simple terms, it is a mover. An actuator requires a control signal and a source of energy";
                    btnPlay.onClick.AddListener(() => playActuator());
                    btnStop.onClick.AddListener(() => stopActuator());
                }
                else if (name == "Glasses")
                {
                    TextTargetName.GetComponent<Text>().text = "Glasses";
                    TextDescription.GetComponent<Text>().text = "Glasses, also known as eyeglasses or spectacles, are devices consisting of glass or hard plastic lenses mounted in a frame that holds them in front of a person's eyes, typically using a bridge over the nose and arms which rest over the ears";
                    btnPlay.onClick.AddListener(() => playGlasses());
                    btnStop.onClick.AddListener(() => stopGlasses());
                    //glasses.transform.localRotation = Quaternion.Euler(-55, 90, 88);
                }
                else if (name == "Magnifying_Glass")
                {
                    TextTargetName.GetComponent<Text>().text = "Magnifying Glass";
                    TextDescription.GetComponent<Text>().text = "A magnifying glass (called a hand lens in laboratory contexts) is a convex lens that is used to produce a magnified image of an object. The lens is usually mounted in a frame with a handle (see image)";
                    btnPlay.gameObject.SetActive(false);
                    btnStop.gameObject.SetActive(false);
                }
                else if (name == "Telescope")
                {
                    TextTargetName.GetComponent<Text>().text = "Monocular";
                    TextDescription.GetComponent<Text>().text = "A monocular is an optical instrument that aids in the observation of remote objects by collecting electromagnetic radiation (such as visible light)[citation needed]. The first known practical telescopes were invented in the Netherlands at the beginning of the 17th century, by using glass lenses.";
                    btnPlay.onClick.AddListener(() => playTelescope());
                    btnStop.onClick.AddListener(() => stopTelescope());
                    //telescope.transform.localRotation = Quaternion.Euler(-34, 90, 0);
                }
                else if (name == "SLR")
                {
                    TextTargetName.GetComponent<Text>().text = "SLR Camera";
                    TextDescription.GetComponent<Text>().text = "A single-lens reflex camera (SLR) is a camera that typically uses a mirror and prism system (hence reflex from the mirror's reflection) that permits the photographer to view through the lens and see exactly what will be captured";
                    btnPlay.gameObject.SetActive(false);
                    btnStop.gameObject.SetActive(false);
                    //camera.transform.localRotation = Quaternion.Euler(-62, 115, 62);
                }
                else if (name == "Microscope")
                {
                    TextTargetName.GetComponent<Text>().text = "Microscope";
                    TextDescription.GetComponent<Text>().text = "A microscope (from the Ancient Greek: μικρός, mikrós, small and σκοπεῖν, skopeîn, to look or see) is an instrument used to see objects that are too small to be seen by the naked eye";
                    btnPlay.onClick.AddListener(() => playMicroscope());
                    btnStop.onClick.AddListener(() => stopMicroscope());
                }
                else if (name == "Voc_Money")
                {
                    TextTargetName.GetComponent<Text>().text = "VOC Coin";
                    TextDescription.GetComponent<Text>().text = "The Dutch East India Company (Dutch: Vereenigde Oostindische Compagnie, often known as VOC) was a chartered company which issued a considerable series of coinage in bronze, silver and gold for its territories in the Far East between 1602 and 1799";
                    btnPlay.onClick.AddListener(() => playVocCoin());
                    btnStop.onClick.AddListener(() => stopVocCoin());
                }
                else if (name == "Voc_Army")
                {
                    TextTargetName.GetComponent<Text>().text = "VOC Army";
                    TextDescription.GetComponent<Text>().text = "The Dutch East India Company (Dutch: Verenigde Oost-Indische Compagnie abbreviated to VOC), was a publicly tradable corporation that was founded in 1602 and became defunct in 1799";
                    btnPlay.onClick.AddListener(() => playVocArmy());
                    btnStop.onClick.AddListener(() => stopVocArmy());
                }
                else if (name == "Indonesian_Army")
                {
                    TextTargetName.GetComponent<Text>().text = "Indonesian Army";
                    TextDescription.GetComponent<Text>().text = "The Indonesian Army (Indonesian: Tentara Nasional Indonesia-Angkatan Darat, TNI–AD), the land component of the Indonesian National Armed Forces, has an estimated strength of 300,000 active personnel.[1] The history of the Indonesian Army has its roots in 1945 when the Tentara Keamanan Rakyat (TKR) Civil Security Forces first emerged as a paramilitary and police corps";
                    btnPlay.onClick.AddListener(() => playIndonesianArmy());
                    btnStop.onClick.AddListener(() => stopIndonesianArmy());
                }
                else if (name == "Proklamasi2")
                {
                    TextTargetName.GetComponent<Text>().text = "Proclamation";
                    TextDescription.GetComponent<Text>().text = "The Proclamation of Indonesian Independence was held on Friday , August 17, 1945 AD , or August 17, 2605 according to the Japanese year , read by Soekarno accompanied by Drs. Mohammad Hatta is located at Jalan Pegangsaan Timur 56 , Central Jakarta";
                    btnPlay.gameObject.SetActive(false);
                    btnStop.gameObject.SetActive(false);
                }
                else if (name == "Monas")
                {
                    TextTargetName.GetComponent<Text>().text = "Monas";
                    TextDescription.GetComponent<Text>().text = "The National Monument (Indonesian: Monumen Nasional, abbreviated Monas) is a 132 m (433 ft) tower in the centre of Merdeka Square, Central Jakarta, symbolizing the fight for Indonesia.";
                    btnPlay.onClick.AddListener(() => playMonas());
                    btnStop.onClick.AddListener(() => stopMonas());
                }
                else if (name == "Joglo")
                {
                    TextTargetName.GetComponent<Text>().text = "Joglo";
                    TextDescription.GetComponent<Text>().text = "Joglo is a type of traditional vernacular house of the Javanese people (Javanese omah). The word joglo refers to the shape of the roof";
                    btnPlay.gameObject.SetActive(false);
                    btnStop.gameObject.SetActive(false);
                    //joglo.transform.localRotation = Quaternion.Euler(-66, 110, -109);
                }
                else if (name == "Batik")
                {
                    TextTargetName.GetComponent<Text>().text = "Batik";
                    TextDescription.GetComponent<Text>().text = "Batik is a technique of wax-resist dyeing applied to whole cloth, or cloth made using this technique originated from Indonesia. Batik is made either by drawing dots and lines of the resist with a spouted tool called a canting";
                    btnPlay.gameObject.SetActive(false);
                    btnStop.gameObject.SetActive(false);
                }
                else if (name == "Baju_Adat")
                {
                    TextTargetName.GetComponent<Text>().text = "Traditional Clothes";
                    TextDescription.GetComponent<Text>().text = "Indonesian traditional clothes are usually used at the time of the wedding and other traditional events";
                    btnPlay.onClick.AddListener(() => playBajuAdat());
                    btnStop.onClick.AddListener(() => stopBajuAdat());
                }
                else if (name == "Saron")
                {
                    TextTargetName.GetComponent<Text>().text = "Saron";
                    TextDescription.GetComponent<Text>().text = "Saron or the so-called ricik, is one of the gamelan instruments that includes the balungan family. In a set of gamelan usually have 4 saron, and all have pelog and slendro versions";
                    btnPlay.onClick.AddListener(() => playSaron());
                    btnStop.onClick.AddListener(() => stopSaron());
                    //saron.transform.localRotation = Quaternion.Euler(0, 90, 55);
                }
                else if (name == "Silat")
                {
                    TextTargetName.GetComponent<Text>().text = "Silat";
                    TextDescription.GetComponent<Text>().text = "Silat is a collective word for a class of indigenous martial arts from a geo-cultural area of Southeast Asia encompassing most of the Nusantara, the Malay Archipelago, and the entirety of the Malay Peninsula";
                    btnPlay.onClick.AddListener(() => playSilat());
                    btnStop.onClick.AddListener(() => stopSilat());
                }
                else if(name == "Japan_Surender")
                {
                    TextTargetName.GetComponent<Text>().text = "Atomic bombing of hiroshima and nagasaki";
                    TextDescription.GetComponent<Text>().text = "During the final stage of World War II, the United States detonated two nuclear weapons over the Japanese cities of Hiroshima and Nagasaki on August 6 and 9, 1945, respectively. The United States dropped the bombs after obtaining the consent of the United Kingdom, as required by the Quebec Agreement";
                    btnPlay.onClick.AddListener(() => playJapan_Surender());
                    btnStop.onClick.AddListener(() => stopJapan_Surender());
                }
                else if (name == "Rengas_Dengklok")
                {
                    TextTargetName.GetComponent<Text>().text = "Rengasdengklok Incident";
                    TextDescription.GetComponent<Text>().text = "The Rengasdengklok incident was a kidnapping event carried out by a number of young men such as Soekarni , Wikana , Aidit and Chaerul Saleh from the Menteng 31  association of Sukarno and Hatta . This event occurred on August 16, 1945 at 03.00. WIB, Soekarno and Hatta were brought to Rengasdengklok , Karawang , to be urged to accelerate the proclamation of independence of the Republic of Indonesia";
                    btnPlay.onClick.AddListener(() => playRengasdengklok());
                    btnStop.onClick.AddListener(() => stopRengasdengklok());
                }
                else if (name == "Malam_Proklamasi")
                {
                    TextTargetName.GetComponent<Text>().text = "Before Proclamation";
                    TextDescription.GetComponent<Text>().text = "A Night before proclamation is the moment where president and vice president of indonesia was preparing the script of indonesian proclamation before the proclamation day";
                    btnPlay.onClick.AddListener(() => playMalamProklamasi());
                    btnStop.onClick.AddListener(() => stopMalamProklamasi());
                }
                else if (name == "Proklamasi1")
                {
                    TextTargetName.GetComponent<Text>().text = "proclamation";
                    TextDescription.GetComponent<Text>().text = "The Proclamation of Indonesian Independence was held on Friday , August 17, 1945 AD , or August 17, 2605 according to the Japanese year , read by Soekarno accompanied by Drs. Mohammad Hatta is located at Jalan Pegangsaan Timur 56 , Central Jakarta";
                    btnPlay.onClick.AddListener(() => playProklamasi());
                    btnStop.onClick.AddListener(() => stopProklamasi());
                }
                else if (name == "Merdeka")
                {
                    TextTargetName.GetComponent<Text>().text = "Independence";
                    TextDescription.GetComponent<Text>().text = "After reading the text of the proclamation, Indonesian citizens have been independent, now they can feel the pleasure until now, and every 17 August they always commemorate with the traditional competition";
                    btnPlay.onClick.AddListener(() => playMerdeka());
                    btnStop.onClick.AddListener(() => stopMerdeka());
                }
            }
        }

        void playSaron()
        {
            stopAllAnimation();
            stopAllAudio();
            saron.Play("action");
        }

        void stopSaron()
        {
            saron.Play("idle");
        }

        void playMonas()
        {
            stopAllAnimation();
            stopAllAudio();
            monas.Play("action");
        }

        void stopMonas()
        {
            monas.Play("idle");
        }

        void playBajuAdat()
        {
            stopAllAnimation();
            stopAllAudio();
            baju_adat.Play("action");
        }

        void stopBajuAdat()
        {
            baju_adat.Play("idle");
        }

        void playSilat()
        {
            stopAllAnimation();
            stopAllAudio();
            silat.Play("action");
        }

        void stopSilat()
        {
            silat.Play("idle");
        }

        void playGlasses()
        {
            stopAllAnimation();
            glasses.Play("action");
            stopAllAudio();
        }

        void stopGlasses()
        {
            glasses.Play("idle");
        }

        void playIndonesianArmy()
        {
            stopAllAnimation();
            indonesian_army.Play("action");
            stopAllAudio();
        }

        void stopIndonesianArmy()
        {
            indonesian_army.Play("idle");
        }

        void playVocArmy()
        {
            stopAllAnimation();
            voc_army.Play("action");
            stopAllAudio();
        }

        void stopVocArmy()
        {
            voc_army.Play("idle");
        }

        void playVocCoin()
        {
            stopAllAnimation();
            voc_coin.Play("action");
            stopAllAudio();
        }

        void stopVocCoin()
        {
            voc_coin.Play("idle");
        }

        void playLogicBoard()
        {
            stopAllAnimation();
            logic_board.Play("action");
            stopAllAudio();
        }

        void stopLogicBoard()
        {
            logic_board.Play("idle");
        }

        void playPlatter()
        {
            stopAllAnimation();
            stopAllAudio();
            platter.Play("action");
        }

        void stopPlatter()
        {
            platter.Play("idle");
        }

        void playSpindle()
        {
            stopAllAnimation();
            spindle.Play("action");
            stopAllAudio();
        }

        void stopSpindle()
        {
            spindle.Play("idle");
        }

        void playActuator()
        {
            stopAllAnimation();
            actuator.Play("action");
            stopAllAudio();
        }

        void stopActuator()
        {
            actuator.Play("idle");
        }

        void playArm()
        {
            stopAllAnimation();
            rw_arm.Play("action");
            stopAllAudio();
        }

        void stopArm()
        {
            rw_arm.Play("idle");
        }
        
        void playJapan_Surender()
        {
            stopAllAnimation();
            stopAllAudio();
            ajapanSurender.Play();
            japan_surender.Play("action");
        }

        void stopJapan_Surender()
        {
            ajapanSurender.Stop();
            japan_surender.Play("idle");
        }

        void playRengasdengklok()
        {
            stopAllAnimation();
            stopAllAudio();
            arengasdengklok.Play();
            rengasdengklok.Play("action");
        }

        void stopRengasdengklok()
        {
            arengasdengklok.Stop();
            rengasdengklok.Play("idle");
        }

        void playMalamProklamasi()
        {
            stopAllAnimation();
            stopAllAudio();
            amalamProklamasi.Play();
            malam_proklamasi.Play("action");
        }

        void stopMalamProklamasi()
        {
            amalamProklamasi.Stop();
            malam_proklamasi.Play("idle");
        }

        void playProklamasi()
        {
            stopAllAnimation();
            stopAllAudio();
            aproklamasi.Play();
            proklamasi.Play("action");
        }

        void stopProklamasi()
        {
            aproklamasi.Stop();
            proklamasi.Play("idle");
        }

        void playMerdeka()
        {
            stopAllAnimation();
            stopAllAudio();
            amerdeka.Play();
            merdeka.Play("action");
        }

        void stopMerdeka()
        {
            amerdeka.Stop();
            merdeka.Play("idle");
        }

        void playTelescope()
        {
            stopAllAnimation();
            stopAllAudio();
            telescope.Play("action");
        }

        void stopTelescope()
        {
            telescope.Play("idle");
        }

        void playMicroscope()
        {
            stopAllAnimation();
            stopAllAudio();
            microsope.Play("action");
        }

        void stopMicroscope()
        {
            microsope.Play("idle");
        }

        void stopAllAudio()
        {
            ajapanSurender.Stop();
            asaron.Stop();
            arengasdengklok.Stop();
            aproklamasi.Stop();
            amalamProklamasi.Stop();
            amerdeka.Stop();
        }

        void stopAllAnimation()
        {
            logic_board.Play("idle");
            platter.Play("idle");
            spindle.Play("idle");
            rw_arm.Play("idle");
            actuator.Play("idle");
            rengasdengklok.Play("idle");
            malam_proklamasi.Play("idle");
            proklamasi.Play("idle");
            japan_surender.Play("idle");
            merdeka.Play("idle");
            glasses.Play("idle");
            telescope.Play("idle");
            microsope.Play("idle");
            platter.Play("idle");
            silat.Play("idle");
            voc_coin.Play("idle");
            indonesian_army.Play("idle");
            voc_army.Play("idle");
        }

    }
}

