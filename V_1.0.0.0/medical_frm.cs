using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class medical_frm : Form
    {
        public medical_frm()
        {
            InitializeComponent();
            lbl_SectionHeading.Text = "Stop Heavy Bleeding";
            //healthplayer.URL = "C:\\Program Files\\How to stop heavy bleeding - First Aid.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[0];
        }
        #region section strings
        string[] section_strings = { "If someone is bleeding heavily, the main aim is to prevent further blood loss and minimise the effects of shock.\r\n\r\nFirst, dial 999 and ask for an ambulance as soon as possible.\r\n\r\nIf you have disposable gloves, use them to reduce the risk of any infection being passed on.\r\n\r\nCheck that there's nothing embedded in the wound. If there is, take care not to press down on the object.\r\n\r\nInstead, press firmly on either side of the object and build up padding around it before bandaging to avoid putting pressure on the object itself.\r\n\r\nDo not try to remove it because it may be helping to slow down the bleeding.\r\n\r\nIf nothing is embedded:\r\n\r\nApply and maintain pressure to the wound with your gloved hand, using a clean pad or dressing if possible. Continue to apply pressure until the bleeding stops.\r\nUse a clean dressing or any clean, soft material to bandage the wound firmly.\r\nIf bleeding continues through the pad, apply pressure to the wound until the bleeding stops, and then apply another pad over the top and bandage it in place. Do not remove the original pad or dressing, but continue to check that the bleeding has stopped.\r\nIf a body part, such as a finger, has been severed, place it in a plastic bag or wrap it in cling film. Do not wash the severed limb.\r\n\r\nWrap the package in soft fabric and place in a container of crushed ice. Do not let the limb touch the ice.\r\n\r\nMake sure the severed limb goes with the patient to hospital.\r\n\r\nAlways seek medical help for bleeding, unless it's minor.",
        "It can be difficult to tell if a person has a broken bone or a joint, as opposed to a simple muscular injury. If you're in any doubt, treat the injury as a broken bone.\r\n\r\nIf the person is unconscious or is bleeding heavily, these must be dealt with first by controlling the bleeding with direct pressure and performing CPR. See the section on bleeding heavily above.\r\n\r\nIf the person is conscious, prevent any further pain or damage by keeping the fracture as still as possible until you get them safely to hospital.\r\n\r\nOnce you have done this, decide whether the best way to get them to hospital is by ambulance or car.\r\n\r\nIf the pain isn't too severe, you could transport them to hospital by car. Get someone else to drive if possible so you can care for the person who is injured during the trip.\r\n\r\nBut call 999 if:\r\n\r\nthey're in a lot of pain and in need of strong painkilling medication – call an ambulance and do not move them\r\nit's obvious they have a broken leg – do not move them, but keep them in the position you found them in and call an ambulance\r\nyou suspect they have injured or broken their back – call an ambulance and do not move them\r\nDo not give the person who is injured anything to eat or drink, as they may need an anaesthetic (numbing medication) when they reach hospital.",
        "If the airway is only partly blocked, the person will usually be able to speak, cry, cough or breathe.\r\n\r\nIn situations like this, a person will usually be able to clear the blockage themselves.\r\n\r\nIf choking is mild:\r\n\r\nEncourage the person to cough to try to clear the blockage.\r\nAsk them to try to spit out the object if it's in their mouth.\r\nDo not put your fingers in their mouth if you can't see the object, as you risk pushing it further down their mouth.\r\nIf coughing doesn't work, start back blows. If choking is severe, the person won't be able to speak, cry, cough or breathe, and without help they'll eventually become unconscious. If coughing doesn't work start back blows.\r\n\r\nHow to do back blows\r\nTo help an adult or child over 1 year old:\r\n\r\nStand behind the person and slightly to one side. Support their chest with 1 hand. Lean the person forward so the object blocking their airway will come out of their mouth, rather than moving further down.\r\nGive up to 5 sharp blows between the person's shoulder blades with the heel of your hand (the heel is between the palm of your hand and your wrist).\r\nCheck if the blockage has cleared.\r\nIf not, give up to 5 abdominal thrusts.\r\nDo not give abdominal thrusts to babies under 1 year old or to pregnant women.\r\n\r\nTo perform abdominal thrusts on a person who is severely choking and isn't in one of the above groups:\r\n\r\nStand behind the person who is choking.\r\nPlace your arms around their waist and bend them well forward.\r\nClench 1 fist and place it just above the person's belly button.\r\nPlace your other hand on top of your fist and pull sharply inwards and upwards.\r\nRepeat this up to 5 times.\r\nThe aim is to get the obstruction out with each chest thrust, rather than necessarily doing all 5.",
        "Giving CPR\r\n1.Check the scene for safety, form an initial impression and use personal protective equipment.\r\n\r\n2.If the person appears unresponsive, check for responsiveness, breathing, life-threatening bleeding or other life-threatening conditions.\r\n\r\n3.If the person does not respond and is not breathing or only gasping call 911 and get equipment or tell someone to do so.\r\n\r\n4.Kneel beside the person. Place the person on their back on a firm flat surface.\r\n\r\n5.Give 30 chest compressions.\r\n\r\n6.Give 2 breaths\r\n\r\n7.Continue giving sets of 30 chest compressions and 2 breaths. Minimize interruptions to chest compressions to less than 10\r\nseconds.\r\n",
        "If you think someone is having or has had a heart attack, call 999 and then move them into a comfortable sitting position.\r\n\r\nSymptoms of a heart attack include:\r\n\r\nchest pain – the pain is usually located in the centre or left side of the chest and can feel like a sensation of pressure, tightness or squeezing\r\npain in other parts of the body – it can feel as if the pain is travelling from the chest down 1 or both arms, or into the jaw, neck, back or abdomen (tummy)\r\nSit the person down and make them comfortable.\r\n\r\nIf they can, it's best for them to sit on the floor with their knees bent and their head and shoulders supported. If possible, place cushions behind them or under their knees.\r\n\r\nIf they're conscious, reassure them and ask them to take a 300mg aspirin tablet to chew slowly, (unless you know they shouldn't take aspirin, for example if they are under 16 or they say they are allergic to it).\r\n\r\nIf the person has any medication for angina, help them to take it.\r\n\r\nMonitor their vital signs, such as their breathing, until help arrives.\r\n\r\nIf the person deteriorates and becomes unconscious, open their airway, check their breathing and, if necessary, start CPR.\r\n\r\nCall 999 to tell them you think the person is now in cardiac arrest (their heart has stopped beating).",
        "Poisoning is potentially life threatening.\r\n\r\nCommon causes of poisoning include:\r\n\r\nswallowing a toxic substance, such as bleach\r\ntaking an overdose of a prescription medicine\r\neating something, like wild plants and fungi\r\nAlcohol poisoning can cause similar symptoms.\r\n\r\nIf you think someone has swallowed a poisonous substance, call 999 to get immediate medical help and advice.\r\n\r\nThe effects of poisoning depend on the substance swallowed, but can include vomiting, loss of consciousness, pain or a burning sensation.\r\n\r\nThe following advice is important:\r\n\r\nFind out what's been swallowed so you can tell the paramedic or doctor.\r\nDo not give the person anything to eat or drink unless a healthcare professional advises you to.\r\nDo not try to cause vomiting.\r\nStay with the person, as their condition may get worse and they could become unconscious.\r\nIf the person becomes unconscious while you're waiting for help to arrive, check for breathing and, if necessary, perform CPR.\r\n\r\nDo not perform mouth-to-mouth resuscitation if the person's mouth or airway is contaminated with the poison.\r\n\r\nDo not leave them if they're unconscious: they could vomit. The vomit could then enter their lungs and make them choke.\r\n\r\nIf they do vomit naturally, try to collect some of it for the ambulance crew – this may help identify the cause of the poisoning.\r\n\r\nIf the patient is conscious and breathing normally, put them into the recovery position and keep checking they're breathing normally.",
        "Pinching puts pressure on the blood vessels and helps stop the blood flow.\r\n \r\nIf the bleeding doesn't stop pinch the nose again for up to 15 minutes. Don't let go for at least five minutes even to check if the\r\n\r\nbleeding has stopped. Seek emergency care if the bleeding doesn't stop after the second try.",
        "If someone is in difficulty in water, don't enter the water unless it's safe to do so. Don't put yourself at risk.\r\n\r\nOnce the person is on land, you need to check if they're breathing. Ask someone to call 999 for medical help.\r\n\r\nIf they're not breathing, open the airway and give 5 initial rescue breaths before starting CPR.\r\n\r\nFind out how to give CPR, including rescue breaths.\r\n\r\nIf the person is unconscious but still breathing, put them into the recovery position with their head lower than their body and call an ambulance immediately.\r\n\r\nContinue watching the patient to ensure they don't stop breathing and continue to breathe normally."};
        #endregion

        private void panelhovering(object sender, EventArgs e)
        {

        }

        private void hoveringfinished(object sender, EventArgs e)
        {
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState= FormWindowState.Maximized;
            }
        }

        private void btn_heavybleeding_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Stop Heavy Bleeding";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\How to stop heavy bleeding - First Aid.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[0];

        }

        private void btn_fractures_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Handle Fractures";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - Fracture and DislocationFirst Aid Pro_1080p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[1];

        }

        private void btn_choking_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Handle Choking";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - SAFE STEPS First Aid  CHOKING Filipino_480p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[2];

        }

        private void btn_CPR_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Administer C.P.R";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - How to perform CPR_1080p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[3];

        }

        private void btn_heartAttack_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Rescue from Heart Attack";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\First Aid Skills_ Heart Attack.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[4];

        }

        private void btn_foodpoisoning_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Stop Food Poisoning";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - Poisoning  Malar First Aid Online Course_1080p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[5];

        }

        private void btn_Nosebleeding_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Stop Nose bleeding";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - First aid If the nose is bleeding_1080p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text = section_strings[6];

        }

        private void btn_drowning_Click(object sender, EventArgs e)
        {
            lbl_SectionHeading.Text = "Rescue from Drowning";
            //healthplayer.URL = "X:\\Videos\\Project\\Medical\\First Aid\\y2mate.com - First Aid For Drowning  Medlink Services Pte Ltd_1080p.mp4";
            //healthplayer.settings.autoStart = false;
            //healthplayer.uiMode = "none";
            //healthplayer.Ctlcontrols.play();
            txt_section.Text += section_strings[7];

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
