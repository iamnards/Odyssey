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
}
