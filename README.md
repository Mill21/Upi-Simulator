# Upi simulator

Upi simulator on katsaus Upin elänmään kun sinulla pitää järjestää äijien illan.

![image](https://github.com/Mill21/Upi-Simulator/assets/151001800/97f15d8f-1399-4296-b5b0-74173321a0e5)

## Pelin esittely

Tältä näyttää kun avaat pelin.

![aloitus](https://github.com/Mill21/Upi-Simulator/assets/151001800/2e10df81-0379-4d38-9314-8af873d05a80)

Tältä näyttää sen jälkeen kun olet painanut "Aloita peli nappia"

![start](https://github.com/Mill21/Upi-Simulator/assets/151001800/fa335e62-aa8c-41ae-85a6-2cd3f28f8027)

Tältä näyttää kun painat "Kirjoita selvennys Kelalle" nappia.

![kela](https://github.com/Mill21/Upi-Simulator/assets/151001800/b185689c-c2b3-42d8-816d-98d41eccf00b)

Tältä näyttää kun painat "Hanki juomat" nappia.

![juoma](https://github.com/Mill21/Upi-Simulator/assets/151001800/48154bf8-b423-4ae9-9068-13e6759511c4)

Tältä näyttää kun painat "Hae ruuat" nappia.

![pizza](https://github.com/Mill21/Upi-Simulator/assets/151001800/5e227ffa-ae3c-48b6-9196-18064b9a2ab6)

Tältä näyttää kun olet painanut kaikkia kolmea nappia ja neljäs "Aloita äijien ilta" nappi aukeaa.

![form1](https://github.com/Mill21/Upi-Simulator/assets/151001800/f9da4ffa-5812-4a08-a505-d3b6f42960f3)

Tältä näyttää kun painat "Aloita äijien ilta" nappia.

![after start](https://github.com/Mill21/Upi-Simulator/assets/151001800/3b4806cf-71d3-43fe-96de-3bade82b1feb)

Tältä näyttää kun olet katsonut "Äijien ilta käyntiin" videon.

![form2](https://github.com/Mill21/Upi-Simulator/assets/151001800/7939e7fe-3f7f-4db7-97dd-400295801365)

Tältä näyttää kun painat "Sytytä "Juhannus" kokko" nappia.

![juhannus](https://github.com/Mill21/Upi-Simulator/assets/151001800/431677d9-835a-4313-a595-cda26b2a9838)

Tältä näyttää kun painat "Sytytä tupakka" nappia.

![tupakki](https://github.com/Mill21/Upi-Simulator/assets/151001800/daa3a43c-cacc-42b4-86d4-e2b9e8e45802)

Tältä näyttää kun painat "Käy kusella" nappia.

![peepee](https://github.com/Mill21/Upi-Simulator/assets/151001800/141806cf-5b68-4d0d-a9d8-a3377eda4509)

Tältä näyttää kun painat "Upi kertoo unelma kumppanista" nappia.

![emanta](https://github.com/Mill21/Upi-Simulator/assets/151001800/34d2db86-f05f-4553-bf63-5d97c6adb7a3)

Tältä näyttää kun painat "Nouse tuolille" nappia.

![tuoli](https://github.com/Mill21/Upi-Simulator/assets/151001800/6366983a-3da7-44bb-b142-09054be99495)

Tältä näyttää kun painat "Kerro ideaali maailmanloppusi" nappia.

![maailmanloppu](https://github.com/Mill21/Upi-Simulator/assets/151001800/6e0ca76b-11d1-4412-9833-88692c6aaf4f)

Tältä näyttää kun olet pelannut pelin läpi.

![Loppu](https://github.com/Mill21/Upi-Simulator/assets/151001800/f6e0259b-0049-4615-8154-97fb4e491a17)


## Sneak Peak Koodiin

Tämä on aloitus sivun ainut nappi, joka avaa Äijien ilta prep sivun ja piilottaa sitten itsensä.

``` C#
private void Startup_nappi_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault() ?? new Form1();
            form1.Show();
            this.Hide();
        }
```
Tässä on yleisin nappi pelissä ja suurin osa pelin napeista toimii näin. 

``` C#

kela_button.Enabled = false;

            Form2 video_Player = new Form2(@"Videot\Kela.mp4", this);
            video_Player.Show();
            if (kela_button.Enabled == false && Drink_button.Enabled == false && Pizza_button.Enabled == false)
            {
                Start_button.Enabled = true;
                if (Application.OpenForms["Form4"] != null)
                {
                    Application.OpenForms["Form4"].Close();
                }
            }

        }
```

Tässä on vähän erinlainen nappi yleisistä. Tässä napissa tulee textbox ennen videota. Tämä on yksi Äijien ilta prep sivun napeista katsoo onko kaikki kolme nappia suoritettu jolloin start nappi aukeaa.

``` C#
private void Hanki_juomat_nappi_Click(object sender, EventArgs e)
        {
            Drink_button.Enabled = false;
            MessageBox.Show("Olet spuge eikä sinulla ole rahaa. Päätät piilottaa juomia kaikkiin taskuihisi.");
            Form2 video_Player = new Form2(@"Videot\Juomat.mp4");
            video_Player.Show();
            if (kela_button.Enabled == false && Drink_button.Enabled == false && Pizza_button.Enabled == false)
            {
                Start_button.Enabled = true;
            }



        }
```

Tässä on nappi joka aukeaa Äijien ilta prep sivulla, kun kaikki kolme nappia on painettu.

``` C#
 private void Button3_Click(object sender, EventArgs e)
        {

            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault() ?? new Form3();
            Form2 video_Player = new Form2(@"Videot\Hökäle start.mp4", this);
            form3.Show();
            video_Player.Show();
            this.Close();
            
        }
```

Tässä on yksi Äijien ilta sivun napeista. Tämä toimii samalla tavalla, kun prep sivun kolme ensimmäistä nappia.

``` C#
 private void Juhannus_nappi_Click(object sender, EventArgs e)
        {
            Midsummer_button.Enabled = false;

            Form2 video_Player = new Form2(@"Videot\Juhannus.mp4");
            video_Player.Show();
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
                
            }
        }
```

Tämä nappi on pelin viimeisellä sivulla, joka antaa sinun sulkea kaikki sivut ja lopettaa pelin.

``` C#
private void Button1_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            
            foreach (Form form in Application.OpenForms)
            {
                
                
                    formsToClose.Add(form);
                
            }
            foreach (Form form in formsToClose)
            {
                form.Visible = true;  
                form.Close();
            }
        }
```

## Jatkokehitys ideat

-Enemmän syvemmän peli kokemuksen
-Ulkoasun kehitys
-Koodin siivoamista

## Coming someday

Aijon tehdä Unityllä jonkun näköisen Upi Simulator pelin, kun minulla on enemmän ohjelmointi kokemusta. Mietin vähän platformer kaltaista peliä tai 3d kauhu peliä.











