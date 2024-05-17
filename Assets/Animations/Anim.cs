using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VaseScaleUp()
    {
        mAnimator.SetTrigger("VaseTrigger");
        mAnimator.ResetTrigger("VaseTriggerReverse");
    }

    public void VaseScaleDown()
    {
        mAnimator.SetTrigger("VaseTriggerReverse");
        mAnimator.ResetTrigger("VaseTrigger");
    }

    public void PlateScaleUp()
    {
        mAnimator.SetTrigger("PlateTrigger");
        mAnimator.ResetTrigger("PlateTriggerReverse");
    }

    public void PlateScaleDown()
    {
        mAnimator.SetTrigger("PlateTriggerReverse");
        mAnimator.ResetTrigger("PlateTrigger");
    }

    public void CameraScaleUp()
    {
        mAnimator.SetTrigger("CameraTrigger");
        mAnimator.ResetTrigger("CameraTriggerReverse");
    }

    public void CameraScaleDown()
    {
        mAnimator.SetTrigger("CameraTriggerReverse");
        mAnimator.ResetTrigger("CameraTrigger");
    }

    public void CeramicScaleUp()
    {
        mAnimator.SetTrigger("CeramicTrigger");
        mAnimator.ResetTrigger("CeramicTriggerReverse");
    }

    public void CeramicScaleDown()
    {
        mAnimator.SetTrigger("CeramicTriggerReverse");
        mAnimator.ResetTrigger("CeramicTrigger");
    }

    public void GantanganScaleUp()
    {
        mAnimator.SetTrigger("GantanganTrigger");
        mAnimator.ResetTrigger("GantanganTriggerReverse");
    }

    public void GantanganScaleDown()
    {
        mAnimator.SetTrigger("GantanganTriggerReverse");
        mAnimator.ResetTrigger("GantanganTrigger");
    }

    public void GreyVaseScaleUp()
    {
        mAnimator.SetTrigger("GreyVaseTrigger");
        mAnimator.ResetTrigger("GreyVaseTriggerReverse");
    }

    public void GreyVaseScaleDown()
    {
        mAnimator.SetTrigger("GreyVaseTriggerReverse");
        mAnimator.ResetTrigger("GreyVaseTrigger");
    }

    public void IronScaleUp()
    {
        mAnimator.SetTrigger("IronTrigger");
        mAnimator.ResetTrigger("IronTriggerReverse");
    }

    public void IronScaleDown()
    {
        mAnimator.SetTrigger("IronTriggerReverse");
        mAnimator.ResetTrigger("IronTrigger");
    }

    public void OldLampScaleUp()
    {
        mAnimator.SetTrigger("OldLampTrigger");
        mAnimator.ResetTrigger("OldLampTriggerReverse");
    }

    public void OldLampScaleDown()
    {
        mAnimator.SetTrigger("OldLampTriggerReverse");
        mAnimator.ResetTrigger("OldLampTrigger");
    }
    
    public void OldSofaScaleUp()
    {
        mAnimator.SetTrigger("OldSofaTrigger");
        mAnimator.ResetTrigger("OldSofaTriggerReverse");
    }

    public void OldSofaScaleDown()
    {
        mAnimator.SetTrigger("OldSofaTriggerReverse");
        mAnimator.ResetTrigger("OldSofaTrigger");
    }

    public void TallCabinetScaleUp()
    {
        mAnimator.SetTrigger("TallCabinetTrigger");
        mAnimator.ResetTrigger("TallCabinetTriggerReverse");
    }

    public void TallCabinetScaleDown()
    {
        mAnimator.SetTrigger("TallCabinetTriggerReverse");
        mAnimator.ResetTrigger("TallCabinetTrigger");
    }

    public void GilingangBatoScaleUp()
    {
        mAnimator.SetTrigger("GilingangBatoTrigger");
        mAnimator.ResetTrigger("GilingangBatoTriggerReverse");
    }

    public void GilingangBatoScaleDown()
    {
        mAnimator.SetTrigger("GilingangBatoTriggerReverse");
        mAnimator.ResetTrigger("GilingangBatoTrigger");
    }

    public void HihipScaleUp()
    {
        mAnimator.SetTrigger("HihipTrigger");
        mAnimator.ResetTrigger("HihipTriggerReverse");
    }

    public void HihipScaleDown()
    {
        mAnimator.SetTrigger("HihipTriggerReverse");
        mAnimator.ResetTrigger("HihipTrigger");
    }

    public void KaritScaleUp()
    {
        mAnimator.SetTrigger("KaritTrigger");
        mAnimator.ResetTrigger("KaritTriggerReverse");
    }

    public void KaritScaleDown()
    {
        mAnimator.SetTrigger("KaritTriggerReverse");
        mAnimator.ResetTrigger("KaritTrigger");
    }

    public void KudkuranScaleUp()
    {
        mAnimator.SetTrigger("KudkuranTrigger");
        mAnimator.ResetTrigger("KudkuranTriggerReverse");
    }

    public void KudkuranScaleDown()
    {
        mAnimator.SetTrigger("KudkuranTriggerReverse");
        mAnimator.ResetTrigger("KudkuranTrigger");
    }

    public void LabanganScaleUp()
    {
        mAnimator.SetTrigger("LabanganTrigger");
        mAnimator.ResetTrigger("LabanganTriggerReverse");
    }

    public void LabanganScaleDown()
    {
        mAnimator.SetTrigger("LabanganTriggerReverse");
        mAnimator.ResetTrigger("LabanganTrigger");
    }

    public void LusongScaleUp()
    {
        mAnimator.SetTrigger("LusongTrigger");
        mAnimator.ResetTrigger("LusongTriggerReverse");
    }

    public void LusongScaleDown()
    {
        mAnimator.SetTrigger("LusongTriggerReverse");
        mAnimator.ResetTrigger("LusongTrigger");
    }

    public void MortarScaleUp()
    {
        mAnimator.SetTrigger("MortarTrigger");
        mAnimator.ResetTrigger("MortarTriggerReverse");
    }

    public void MortarScaleDown()
    {
        mAnimator.SetTrigger("MortarTriggerReverse");
        mAnimator.ResetTrigger("MortarTrigger");
    }

    public void OldFanScaleUp()
    {
        mAnimator.SetTrigger("OldFanTrigger");
        mAnimator.ResetTrigger("OldFanTriggerReverse");
    }

    public void OldFanScaleDown()
    {
        mAnimator.SetTrigger("OldFanTriggerReverse");
        mAnimator.ResetTrigger("OldFanTrigger");
    }

    public void PrinsaScaleUp()
    {
        mAnimator.SetTrigger("PrinsaTrigger");
        mAnimator.ResetTrigger("PrinsaTriggerReverse");
    }

    public void PrinsaScaleDown()
    {
        mAnimator.SetTrigger("PrinsaTriggerReverse");
        mAnimator.ResetTrigger("PrinsaTrigger");
    }

    public void SmokePipeScaleUp()
    {
        mAnimator.SetTrigger("SmokePipeTrigger");
        mAnimator.ResetTrigger("SmokePipeTriggerReverse");
    }

    public void SmokePipeScaleDown()
    {
        mAnimator.SetTrigger("SmokePipeTriggerReverse");
        mAnimator.ResetTrigger("SmokePipeTrigger");
    }

    public void SuyodScaleUp()
    {
        mAnimator.SetTrigger("SuyodTrigger");
        mAnimator.ResetTrigger("SuyodTriggerReverse");
    }

    public void SuyodScaleDown()
    {
        mAnimator.SetTrigger("SuyodTriggerReverse");
        mAnimator.ResetTrigger("SuyodTrigger");
    }

    public void TeapotsScaleUp()
    {
        mAnimator.SetTrigger("TeapotsTrigger");
        mAnimator.ResetTrigger("TeapotsTriggerReverse");
    }

    public void TeapotsScaleDown()
    {
        mAnimator.SetTrigger("TeapotsTriggerReverse");
        mAnimator.ResetTrigger("TeapotsTrigger");
    }
    
    public void TiklisScaleUp()
    {
        mAnimator.SetTrigger("TiklisTrigger");
        mAnimator.ResetTrigger("TiklisTriggerReverse");
    }

    public void TiklisScaleDown()
    {
        mAnimator.SetTrigger("TiklisTriggerReverse");
        mAnimator.ResetTrigger("TiklisTrigger");
    }

    public void BaulScaleUp()
    {
        mAnimator.SetTrigger("BaulTrigger");
        mAnimator.ResetTrigger("BaulTriggerReverse");
    }

    public void BaulScaleDown()
    {
        mAnimator.SetTrigger("BaulTriggerReverse");
        mAnimator.ResetTrigger("BaulTrigger");
    }

    public void KabayoScaleUp()
    {
        mAnimator.SetTrigger("KabayoTrigger");
        mAnimator.ResetTrigger("KabayoTriggerReverse");
    }

    public void KabayoScaleDown()
    {
        mAnimator.SetTrigger("KabayoTriggerReverse");
        mAnimator.ResetTrigger("KabayoTrigger");
    }

    public void PalayokScaleUp()
    {
        mAnimator.SetTrigger("PalayokTrigger");
        mAnimator.ResetTrigger("PalayokTriggerReverse");
    }

    public void PalayokScaleDown()
    {
        mAnimator.SetTrigger("PalayokTriggerReverse");
        mAnimator.ResetTrigger("PalayokTrigger");
    }

    public void TableScaleUp()
    {
        mAnimator.SetTrigger("TableTrigger");
        mAnimator.ResetTrigger("TableTriggerReverse");
    }

    public void TableScaleDown()
    {
        mAnimator.SetTrigger("TableTriggerReverse");
        mAnimator.ResetTrigger("TableTrigger");
    }

    public void TanchongScaleUp()
    {
        mAnimator.SetTrigger("TanchongTrigger");
        mAnimator.ResetTrigger("TanchongTriggerReverse");
    }

    public void TanchongScaleDown()
    {
        mAnimator.SetTrigger("TanchongTriggerReverse");
        mAnimator.ResetTrigger("TanchongTrigger");
    }

    public void KalananScaleUp()
    {
        mAnimator.SetTrigger("KalananTrigger");
        mAnimator.ResetTrigger("KalananTriggerReverse");
    }

    public void KalananScaleDown()
    {
        mAnimator.SetTrigger("KalananTriggerReverse");
        mAnimator.ResetTrigger("KalananTrigger");
    }

    public void BottlesScaleUp()
    {
        mAnimator.SetTrigger("BottlesTrigger");
        mAnimator.ResetTrigger("BottlesTriggerReverse");
    }

    public void BottlesScaleDown()
    {
        mAnimator.SetTrigger("BottlesTriggerReverse");
        mAnimator.ResetTrigger("BottlesTrigger");
    }

    public void RadioScaleUp()
    {
        mAnimator.SetTrigger("RadioTrigger");
        mAnimator.ResetTrigger("RadioTriggerReverse");
    }

    public void RadioScaleDown()
    {
        mAnimator.SetTrigger("RadioTriggerReverse");
        mAnimator.ResetTrigger("RadioTrigger");
    }

    public void CandleScaleUp()
    {
        mAnimator.SetTrigger("CandleTrigger");
        mAnimator.ResetTrigger("CandleTriggerReverse");
    }

    public void CandleScaleDown()
    {
        mAnimator.SetTrigger("CandleTriggerReverse");
        mAnimator.ResetTrigger("CandleTrigger");
    }

    public void AraroScaleUp()
    {
        mAnimator.SetTrigger("AraroTrigger");
        mAnimator.ResetTrigger("AraroTriggerReverse");
    }

    public void AraroScaleDown()
    {
        mAnimator.SetTrigger("AraroTriggerReverse");
        mAnimator.ResetTrigger("AraroTrigger");
    }

    public void FedoraScaleUp()
    {
        mAnimator.SetTrigger("FedoraTrigger");
        mAnimator.ResetTrigger("FedoraTriggerReverse");
    }

    public void FedoraScaleDown()
    {
        mAnimator.SetTrigger("FedoraTriggerReverse");
        mAnimator.ResetTrigger("FedoraTrigger");
    }

    public void RizalScaleUp()
    {
        mAnimator.SetTrigger("RizalTrigger");
        mAnimator.ResetTrigger("RizalTriggerReverse");
    }

    public void RizalScaleDown()
    {
        mAnimator.SetTrigger("RizalTriggerReverse");
        mAnimator.ResetTrigger("RizalTrigger");
    }

    public void SalakotScaleUp()
    {
        mAnimator.SetTrigger("SalakotTrigger");
        mAnimator.ResetTrigger("SalakotTriggerReverse");
    }

    public void SalakotScaleDown()
    {
        mAnimator.SetTrigger("SalakotTriggerReverse");
        mAnimator.ResetTrigger("SalakotTrigger");
    }

    public void KatamScaleUp()
    {
        mAnimator.SetTrigger("KatamTrigger");
        mAnimator.ResetTrigger("KatamTriggerReverse");
    }

    public void KatamScaleDown()
    {
        mAnimator.SetTrigger("KatamTriggerReverse");
        mAnimator.ResetTrigger("KatamTrigger");
    }

    public void RecorderScaleUp()
    {
        mAnimator.SetTrigger("RecorderTrigger");
        mAnimator.ResetTrigger("RecorderTriggerReverse");
    }

    public void RecorderScaleDown()
    {
        mAnimator.SetTrigger("RecorderTriggerReverse");
        mAnimator.ResetTrigger("RecorderTrigger");
    }

    public void TingkopScaleUp()
    {
        mAnimator.SetTrigger("TingkopTrigger");
        mAnimator.ResetTrigger("TingkopTriggerReverse");
    }

    public void TingkopScaleDown()
    {
        mAnimator.SetTrigger("TingkopTriggerReverse");
        mAnimator.ResetTrigger("TingkopTrigger");
    }

    public void LaptopScaleUp()
    {
        mAnimator.SetTrigger("LaptopTrigger");
        mAnimator.ResetTrigger("LaptopTriggerReverse");
    }

    public void LaptopScaleDown()
    {
        mAnimator.SetTrigger("LaptopTriggerReverse");
        mAnimator.ResetTrigger("LaptopTrigger");
    }

    public void UtensilsScaleUp()
    {
        mAnimator.SetTrigger("UtensilsTrigger");
        mAnimator.ResetTrigger("UtensilsTriggerReverse");
    }

    public void UtensilsScaleDown()
    {
        mAnimator.SetTrigger("UtensilsTriggerReverse");
        mAnimator.ResetTrigger("UtensilsTrigger");
    }

    public void EnriqueScaleUp()
    {
        mAnimator.SetTrigger("EnriqueTrigger");
        mAnimator.ResetTrigger("EnriqueTriggerReverse");
    }

    public void EnriqueScaleDown()
    {
        mAnimator.SetTrigger("EnriqueTriggerReverse");
        mAnimator.ResetTrigger("EnriqueTrigger");
    }

    public void FelipeScaleUp()
    {
        mAnimator.SetTrigger("FelipeTrigger");
        mAnimator.ResetTrigger("FelipeTriggerReverse");
    }

    public void FelipeScaleDown()
    {
        mAnimator.SetTrigger("FelipeTriggerReverse");
        mAnimator.ResetTrigger("FelipeTrigger");
    }

    public void NorielScaleUp()
    {
        mAnimator.SetTrigger("NorielTrigger");
        mAnimator.ResetTrigger("NorielTriggerReverse");
    }

    public void NorielScaleDown()
    {
        mAnimator.SetTrigger("NorielTriggerReverse");
        mAnimator.ResetTrigger("NorielTrigger");
    }

    public void DeDiosScaleUp()
    {
        mAnimator.SetTrigger("DeDiosTrigger");
        mAnimator.ResetTrigger("DeDiosTriggerReverse");
    }

    public void DeDiosScaleDown()
    {
        mAnimator.SetTrigger("DeDiosTriggerReverse");
        mAnimator.ResetTrigger("DeDiosTrigger");
    }

    public void AlvarezScaleUp()
    {
        mAnimator.SetTrigger("AlvarezTrigger");
        mAnimator.ResetTrigger("AlvarezTriggerReverse");
    }

    public void AlvarezScaleDown()
    {
        mAnimator.SetTrigger("AlvarezTriggerReverse");
        mAnimator.ResetTrigger("AlvarezTrigger");
    }
}
