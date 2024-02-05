using Microsoft.VisualBasic;

namespace Palworld_ServerConfigurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Generate and save file";
            // Common Parameters
            toolTip1.SetToolTip(ServerName, "Name of your server");
            toolTip1.SetToolTip(ServerDescription, "Description of your server");
            toolTip1.SetToolTip(AdminPassword, "Administrator password of your server");
            toolTip1.SetToolTip(ServerPassword, "User password of your server");
            toolTip1.SetToolTip(PublicPort, "Port for connection on your server");
            toolTip1.SetToolTip(PublicIp, "IP adress of your server");
            toolTip1.SetToolTip(DayTimeSpeedRate, "Duration of the day");
            toolTip1.SetToolTip(NightTimeSpeedRate, "Duration of the night");
            toolTip1.SetToolTip(ExpRate, "Experience rate");
            toolTip1.SetToolTip(BuildObjectDamageRate, "Build object damage rate");
            toolTip1.SetToolTip(BuildObjectDeteriorationRate, "Build object deterioration rate");
            toolTip1.SetToolTip(CollectionDropRate, "Collection drop rate");
            toolTip1.SetToolTip(EnemyDropItemRate, "Item drop rate by enemy");
            toolTip1.SetToolTip(BaseCampMaxNUm, "Base camp max size");
            toolTip1.SetToolTip(CollectionObjectRespawnSpeedRate, "Collection object respawn speed rate"); 
            toolTip1.SetToolTip(BaseCampWorkerMaxNum, "Max number of pals in your base camp");
            toolTip1.SetToolTip(AutoResetGuildNoOnlinePlayers, "Reset player if no online for x hours");
            toolTip1.SetToolTip(AutoResetGuildTimeNoOnlinePlayers, "Hours before resetting no online player");
            toolTip1.SetToolTip(GuildPlayerMaxNum, "Maximun of guild players ");
            toolTip1.SetToolTip(StartLocationSelectByMap, "Start location select by map");
            toolTip1.SetToolTip(CoopPlayerMaxNum, "Maximun of coop players");
            toolTip1.SetToolTip(ServerPlayerMaxNum, "Maximun number of players by server");
            toolTip1.SetToolTip(EnableInvaderEnemy, "Enable or disable enemy raid");

            // Players parameters
            toolTip1.SetToolTip(PlayerDamageRateAttack, "Damage rate per player attack");
            toolTip1.SetToolTip(PlayerDamageRateDefense, "Player defense rate");
            toolTip1.SetToolTip(PlayerStomachDecreaceRate, "Hunger rate");
            toolTip1.SetToolTip(PlayerStaminaDecreaceRate, "Losing Stamina rate");
            toolTip1.SetToolTip(PlayerAutoHPRegeneRate, "HP regen rate");
            toolTip1.SetToolTip(PlayerAutoHpRegeneRateInSleep, "HP regen rate while sleeping");
            toolTip1.SetToolTip(EnablePlayerToPlayerDamage, "Player to player damage");
            toolTip1.SetToolTip(EnableFriendlyFire, "Friendly fire");
            toolTip1.SetToolTip(EnableAimAssistPad, "Gamepad aim assistance");
            toolTip1.SetToolTip(EnableAimAssistKeyboard, "Keyboard aim assistance");
            toolTip1.SetToolTip(WorkSpeedRate, "Work speed rate");
            toolTip1.SetToolTip(CollectionDropRate, "Collection drop rate");
            toolTip1.SetToolTip(EnemyDropItemRate, "Item drop rate by enemy");
            toolTip1.SetToolTip(BaseCampMaxNUm, "Base camp max size");
            toolTip1.SetToolTip(CollectionObjectRespawnSpeedRate, "Collection object respawn speed rate");
            toolTip1.SetToolTip(BaseCampWorkerMaxNum, "Max number of pals in your base camp");
            toolTip1.SetToolTip(AutoResetGuildNoOnlinePlayers, "Reset player if no online for x hours");
            toolTip1.SetToolTip(AutoResetGuildTimeNoOnlinePlayers, "Hours before resetting no online player");
            toolTip1.SetToolTip(GuildPlayerMaxNum, "Maximun of guild players ");
            toolTip1.SetToolTip(StartLocationSelectByMap, "Start location select by map");
            toolTip1.SetToolTip(CoopPlayerMaxNum, "Maximun of coop players");
            toolTip1.SetToolTip(ServerPlayerMaxNum, "Maximun number of players by server");
            toolTip1.SetToolTip(EnableInvaderEnemy, "Enable or disable enemy raid");

            //Pals parameters
            toolTip1.SetToolTip(PalCaptureRate, "Pal capture rate");
            toolTip1.SetToolTip(PalSpawnNumRate, "Number of spawning pals");
            toolTip1.SetToolTip(PalDamageRateAttack, "Damage rate per pal attack");
            toolTip1.SetToolTip(PalDamageRateDefense, "Pal defense rate");
            toolTip1.SetToolTip(PalStomachDecreaceRate, "Pal hunger rate");
            toolTip1.SetToolTip(PalStaminaDecreaceRate, "Pal losing Stamina rate");
            toolTip1.SetToolTip(PalAutoHPRegeneRate, "Pal HP regen rate");
            toolTip1.SetToolTip(PalAutoHpRegeneRateInSleep, "Pal HP regen rate while sleeping");
            toolTip1.SetToolTip(PalEggDefaultHatchingTime, "Hatching duration");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ServerName.Text == string.Empty)
                {
                    MessageBox.Show("Server name is empty");
                }
            else if(PublicPort.Text == string.Empty)
                {
                MessageBox.Show("Public port is empty");
            }
            else if (PublicIp.Text == string.Empty)
            {
                MessageBox.Show("Public IP is empty");
            }
            else
             { 
                string FileContent;
                FileContent = "[/Script/Pal.PalGameWorldSettings]\r\nOptionSettings=(Difficulty=None,\r\nDayTimeSpeedRate=" + DayTimeSpeedRate.Text + ",\r\nNightTimeSpeedRate=" + NightTimeSpeedRate.Text + ",\r\nExpRate=" + ExpRate.Text + ",\r\nPalCaptureRate=" + PalCaptureRate.Text + ",\r\nPalSpawnNumRate=" + PalSpawnNumRate.Text + ",\r\nPalDamageRateAttack=" + PalDamageRateAttack.Text + ",\r\nPalDamageRateDefense=" + PalDamageRateDefense.Text + ",\r\nPlayerDamageRateAttack=" + PlayerDamageRateAttack.Text + ",\r\nPlayerDamageRateDefense=" + PlayerDamageRateDefense.Text + ",\r\nPlayerStomachDecreaceRate=" + PlayerStomachDecreaceRate.Text + ",\r\nPlayerStaminaDecreaceRate=" + PlayerStaminaDecreaceRate.Text + ",\r\nPlayerAutoHPRegeneRate=" + PlayerAutoHPRegeneRate.Text + ",\r\nPlayerAutoHpRegeneRateInSleep=" + PlayerAutoHpRegeneRateInSleep.Text + ",\r\nPalStomachDecreaceRate=" + PalStomachDecreaceRate.Text + ",\r\nPalStaminaDecreaceRate=" + PalStaminaDecreaceRate.Text + ",\r\nPalAutoHPRegeneRate=" + PalAutoHPRegeneRate.Text + ",\r\nPalAutoHpRegeneRateInSleep=" + PalAutoHpRegeneRateInSleep.Text + ",\r\nBuildObjectDamageRate=" + BuildObjectDamageRate.Text + ",\r\nBuildObjectDeteriorationDamageRate=" + BuildObjectDeteriorationRate.Text + ",\r\nCollectionDropRate=" + CollectionDropRate.Text + ",\r\nCollectionObjectHpRate=1.000000,\r\nCollectionObjectRespawnSpeedRate=" + CollectionObjectRespawnSpeedRate.Text + ",\r\nEnemyDropItemRate=100.000000,\r\nDeathPenalty=All,\r\nbEnablePlayerToPlayerDamage=" + EnablePlayerToPlayerDamage.Text + ",\r\nbEnableFriendlyFire=" + EnableFriendlyFire.Text + ",\r\nbEnableInvaderEnemy=" + EnableInvaderEnemy.Text + ",\r\nbActiveUNKO=False,\r\nbEnableAimAssistPad=" + EnableAimAssistPad.Text + ",\r\nbEnableAimAssistKeyboard=" + EnableAimAssistKeyboard.Text + ",\r\nDropItemMaxNum=3000,\r\nDropItemMaxNum_UNKO=100,\r\nBaseCampMaxNum=" + BaseCampMaxNUm.Text + ",\r\nBaseCampWorkerMaxNum=" + BaseCampWorkerMaxNum.Text + ",\r\nDropItemAliveMaxHours=1.000000,\r\nbAutoResetGuildNoOnlinePlayers=" + AutoResetGuildNoOnlinePlayers.Text + ",\r\nAutoResetGuildTimeNoOnlinePlayers=" + AutoResetGuildTimeNoOnlinePlayers.Text + ",\r\nGuildPlayerMaxNum=" + GuildPlayerMaxNum.Text + ",\r\nPalEggDefaultHatchingTime=" + PalEggDefaultHatchingTime.Text + ",\r\nWorkSpeedRate=" + WorkSpeedRate.Text + ",\r\nbIsMultiplay=False,\r\nbIsPvP=False,\r\nbCanPickupOtherGuildDeathPenaltyDrop=False,\r\nbEnableNonLoginPenalty=True,\r\nbEnableFastTravel=True,\r\nbIsStartLocationSelectByMap=" + StartLocationSelectByMap.Text + ",\r\nbExistPlayerAfterLogout=False,\r\nbEnableDefenseOtherGuildPlayer=False,\r\nCoopPlayerMaxNum=" + CoopPlayerMaxNum.Text + ",\r\nServerPlayerMaxNum=" + ServerPlayerMaxNum.Text + ",\r\nServerName=\"" + ServerName.Text + "\",\r\nServerDescription=\"" + ServerDescription.Text + "\",\r\nAdminPassword=\"" + AdminPassword.Text + "\",\r\nServerPassword=\"" + ServerPassword.Text + "\",\r\nPublicPort=" + PublicPort.Text + ",\r\nPublicIP=\"" + PublicIp.Text + "\",\r\nRCONEnabled=False,\r\nRCONPort=25575,\r\nRegion=\"\",\r\nbUseAuth=True,\r\nBanListURL=\"https://api.palworldgame.com/api/banlist.txt\")\r\n";
                saveFileDialog1.Filter = "ini File|*.ini";
                saveFileDialog1.Title = "Save PalWorldSettings.ini";
                saveFileDialog1.DefaultExt = "*.ini";
                saveFileDialog1.FileName = "PalWorldSettings.ini";
            
                Stream myStream;
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    saveFileDialog1.ShowDialog();
                    try
                    {
                        File.WriteAllText(saveFileDialog1.FileName, FileContent);
                        myStream.Close();
                    }
                    catch
                    {
                        myStream.Close();
                    }
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
