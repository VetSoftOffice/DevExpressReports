$base = "E:\VetSoft Projects .Net2025\VetSoft Projects\Soos\DevExpressReports\Reports\VetLab"

function Fix-File {
    param([string]$relativePath, [array]$replacements)
    $fullPath = Join-Path $base $relativePath
    $bytes = [System.IO.File]::ReadAllBytes($fullPath)
    $utf8 = [System.Text.UTF8Encoding]::new($false)
    $text = $utf8.GetString($bytes)
    
    $fixed = 0
    foreach ($r in $replacements) {
        if ($text.Contains($r.Old)) {
            $text = $text.Replace($r.Old, $r.New)
            $fixed++
        }
    }
    
    $newBytes = $utf8.GetBytes($text)
    [System.IO.File]::WriteAllBytes($fullPath, $newBytes)
    Write-Host "$relativePath : Fixed $fixed / $($replacements.Count) entries"
}

# ========== SR_VL_HI.repx ==========
$hi = @(
    @{Old='Culture="ar" Path="Text" Data="?????? ???????: [?FilterData]"'; New='Culture="ar" Path="Text" Data="بيانات التصفية: [?FilterData]"'}
    @{Old='Culture="ar" Path="Description" Data="??"'; New='Culture="ar" Path="Description" Data="من"'}
    @{Old='Culture="ar" Path="Description" Data="???"'; New='Culture="ar" Path="Description" Data="الى"'}
    @{Old='Culture="ar" Path="Description" Data="??? ????"'; New='Culture="ar" Path="Description" Data="حجم الخط"'}
    @{Old='Culture="ar" Path="Description" Data="????? ??? ???????"'; New='Culture="ar" Path="Description" Data="إخفاء ذيل التقرير"'}
    @{Old='Culture="ar" Path="Description" Data="????? ??? ???????"'; New='Culture="ar" Path="Description" Data="إخفاء رأس التقرير"'}
    @{Old='Culture="ar" Path="Description" Data="??? ?? ?????? ??????"'; New='Culture="ar" Path="Description" Data="عرض من اليمين لليسار"'}
    @{Old='Culture="ar" Path="Description" Data="??? ????????? / ????"'; New='Culture="ar" Path="Description" Data="عدد المجموعات / صفحة"'}
    @{Old='Culture="ar" Path="Description" Data="??? ???????"'; New='Culture="ar" Path="Description" Data="عرض التوقيع"'}
    @{Old='Culture="ar" Path="Description" Data="??? ??????? ?? ?? ???????"'; New='Culture="ar" Path="Description" Data="عرض التوقيع في كل الصفحات"'}
    @{Old='Culture="ar" Path="DisplayName" Data="???? ????? ??????"'; New='Culture="ar" Path="DisplayName" Data="قيود يومية تفصيلي"'}
    @{Old='Culture="ar" Path="Text" Data="???? ???: [?VetLabCode]"'; New='Culture="ar" Path="Text" Data="معمل بيطري: [?VetLabCode]"'}
    @{Old='Culture="ar" Path="Text" Data="????"'; New='Culture="ar" Path="Text" Data="الدجاج"'}
    @{Old='Culture="ar" Path="Text" Data="????? ???????"'; New='Culture="ar" Path="Text" Data="تاريخ النتيجة"'}
    @{Old='Culture="ar" Path="Text" Data="??? ??????"'; New='Culture="ar" Path="Text" Data="نوع الطائر"'}
    @{Old='Culture="ar" Path="Text" Data="?????"'; New='Culture="ar" Path="Text" Data="المزرعة"'}
    @{Old='Culture="ar" Path="Text" Data="???????"'; New='Culture="ar" Path="Text" Data="النتيجة"'}
    @{Old='Culture="ar" Path="Text" Data="?????"'; New='Culture="ar" Path="Text" Data="الدورة"'}
    @{Old='Culture="ar" Path="Text" Data="??? ??????&#x9;"'; New='Culture="ar" Path="Text" Data="نوع&#x9;"'}
    @{Old='Culture="ar" Path="Text" Data="???? %"'; New='Culture="ar" Path="Text" Data="النفوق %"'}
    @{Old='Culture="ar" Path="Text" Data="???????"'; New='Culture="ar" Path="Text" Data="الاجمالي"'}
    @{Old='Culture="ar" Path="Text" Data=" ??????? ??????? ?????? ???????"'; New='Culture="ar" Path="Text" Data="معدل الموت والمخلفات والانتاج"'}
    @{Old='Culture="ar" Path="Text" Data="??????"'; New='Culture="ar" Path="Text" Data="المورد"'}
    @{Old='Culture="ar" Path="Text" Data="????? (??????)"'; New='Culture="ar" Path="Text" Data="العمر (أسابيع)"'}
    @{Old='Culture="ar" Path="Text" Data="??? ????????"'; New='Culture="ar" Path="Text" Data="رقم الدفعة"'}
    @{Old='Culture="ar" Path="Text" Data="????? ??????????? ????????"'; New='Culture="ar" Path="Text" Data="بي سي ار التاجي"'}
    @{Old='Culture="ar" Path="Text" Data="??? ????? ??????????? ???????? (??????)"'; New='Culture="ar" Path="Text" Data="عمر بي سي ار التاجي (أسابيع)"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??????"'; New='Culture="ar" Path="Text" Data="بيانات العينة"'}
)
Fix-File "SR_VL_HI\SR_VL_HI.repx" $hi

# ========== SR_VL_Interpretation.repx ==========
$interp = @(
    @{Old='Culture="ar" Path="Text" Data="?????? ???????: [?FilterData]"'; New='Culture="ar" Path="Text" Data="بيانات التصفية: [?FilterData]"'}
    @{Old='Culture="ar" Path="Text" Data="???? ?????: [?VetLabCode]"'; New='Culture="ar" Path="Text" Data="معمل بيطري: [?VetLabCode]"'}
    @{Old='Culture="ar" Path="Text" Data="??????: [Place]"'; New='Culture="ar" Path="Text" Data="الموقع: [Place]"'}
    @{Old='Culture="ar" Path="Text" Data="???? ?????? : [LabRef]"'; New='Culture="ar" Path="Text" Data="رقم المرجع المختبري : [LabRef]"'}
)
Fix-File "SR_VL_Interpretation\SR_VL_Interpretation.repx" $interp

# ========== SR_VL_IsoBactSns_SAL_PQP1.repx ==========
$iso = @(
    @{Old='Culture="ar" Path="Text" Data="??: [?DateFrom!dd-MM-yyyy]"'; New='Culture="ar" Path="Text" Data="التاريخ: [?DateFrom!dd-MM-yyyy]"'}
    @{Old='Culture="ar" Path="Text" Data="?????:[FeedMill]"'; New='Culture="ar" Path="Text" Data="الموقع:[FeedMill]"'}
    @{Old='Culture="ar" Path="Text" Data=".?"'; New='Culture="ar" Path="Text" Data="العامل المضاد للبكتيريا"'}
    @{Old='Culture="ar" Path="Text" Data="???? ???????"'; New='Culture="ar" Path="Text" Data="محتوي القرص (ميكروغرام)"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??? ?????? ????????"'; New='Culture="ar" Path="Text" Data="النتيجة المحسوبة من المنطقة"'}
    @{Old='Culture="ar" Path="Text" Data="???? ???"'; New='Culture="ar" Path="Text" Data="-zone of inhibition-"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??????"'; New='Culture="ar" Path="Text" Data="النتيجة النهائية"'}
    @{Old='Culture="ar" Path="Text" Data="????????? ???????? ????????"'; New='Culture="ar" Path="Text" Data="الحساسية المحسوبة من المنطقة"'}
)
Fix-File "SR_VL_IsoBactSns_SAL_PQP1\SR_VL_IsoBactSns_SAL_PQP1.repx" $iso

# ========== SR_VL_PostMortm.repx ==========
$post = @(
    @{Old='Culture="ar" Path="Text" Data="?????? ???????: [?FilterData]"'; New='Culture="ar" Path="Text" Data="بيانات التصفية: [?FilterData]"'}
    @{Old='Culture="ar" Path="Text" Data="??? ???????"'; New='Culture="ar" Path="Text" Data="تاريخ النتيجة"'}
    @{Old='Culture="ar" Path="Text" Data="????? (??????)"'; New='Culture="ar" Path="Text" Data="العمر (أسابيع)"'}
    @{Old='Culture="ar" Path="Text" Data="????? ????????"'; New='Culture="ar" Path="Text" Data="الوزن (كجم)"'}
    @{Old='Culture="ar" Path="Text" Data="????? ?????"'; New='Culture="ar" Path="Text" Data="الاجمالي"'}
    @{Old='Culture="ar" Path="Text" Data="??????? ????"'; New='Culture="ar" Path="Text" Data="النفوق"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ????"'; New='Culture="ar" Path="Text" Data="الناتج"'}
    @{Old='Culture="ar" Path="Text" Data="????? ?? ???????"'; New='Culture="ar" Path="Text" Data="الاجمالي الكلي"'}
    @{Old='Culture="ar" Path="Text" Data="????? ???????"'; New='Culture="ar" Path="Text" Data="نوع التحليل"'}
)
Fix-File "SR_VL_PostMortm\SR_VL_PostMortm.repx" $post

# ========== SR_VL_Salmonella.repx ==========
$salm = @(
    @{Old='Culture="ar" Path="Text" Data="?????? ???????: [?FilterData]"'; New='Culture="ar" Path="Text" Data="بيانات التصفية: [?FilterData]"'}
    @{Old='Culture="ar" Path="Text" Data="????? ????????"'; New='Culture="ar" Path="Text" Data="الوزن (كجم)"'}
    @{Old='Culture="ar" Path="Text" Data="????? ?????"'; New='Culture="ar" Path="Text" Data="الاجمالي"'}
    @{Old='Culture="ar" Path="Text" Data="????? ???????"'; New='Culture="ar" Path="Text" Data="نوع التحليل"'}
    @{Old='Culture="ar" Path="Text" Data="????? ????????"'; New='Culture="ar" Path="Text" Data="الوزن (كجم)"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??? ?????? ????????"'; New='Culture="ar" Path="Text" Data="النتيجة المحسوبة من المنطقة"'}
    @{Old='Culture="ar" Path="Text" Data="???? ???"'; New='Culture="ar" Path="Text" Data="zone of inhibition"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??????"'; New='Culture="ar" Path="Text" Data="النتيجة النهائية"'}
    @{Old='Culture="ar" Path="Text" Data="????????? ???????? ????????"'; New='Culture="ar" Path="Text" Data="الحساسية المحسوبة من المنطقة"'}
    @{Old='Culture="ar" Path="Text" Data="???? ???????"'; New='Culture="ar" Path="Text" Data="محتوي القرص"'}
)
Fix-File "SR_VL_Salmonella\SR_VL_Salmonella.repx" $salm

# ========== SR_VL_StaffWaterHyg.repx ==========
$staff = @(
    @{Old='Culture="ar" Path="Text" Data="?????? ???????: [?FilterData]"'; New='Culture="ar" Path="Text" Data="بيانات التصفية: [?FilterData]"'}
    @{Old='Culture="ar" Path="Text" Data="????? ????????"'; New='Culture="ar" Path="Text" Data="الوزن (كجم)"'}
    @{Old='Culture="ar" Path="Text" Data="??? ?????? ??????"'; New='Culture="ar" Path="Text" Data="الموقع والفرع والقسم"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??????"'; New='Culture="ar" Path="Text" Data="نوع العينة"'}
    @{Old='Culture="ar" Path="Text" Data="????? ?????"'; New='Culture="ar" Path="Text" Data="الاجمالي"'}
    @{Old='Culture="ar" Path="Text" Data="??? ???????"'; New='Culture="ar" Path="Text" Data="الوزن الصافي"'}
    @{Old='Culture="ar" Path="Text" Data="??????? ????"'; New='Culture="ar" Path="Text" Data="النفوق"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ????"'; New='Culture="ar" Path="Text" Data="الناتج"'}
    @{Old='Culture="ar" Path="Text" Data="????? ?? ???????"'; New='Culture="ar" Path="Text" Data="الاجمالي الكلي"'}
    @{Old='Culture="ar" Path="Text" Data="????? ???????"'; New='Culture="ar" Path="Text" Data="نوع التحليل"'}
    @{Old='Culture="ar" Path="Text" Data="???? ?????: [?VetLabCode]"'; New='Culture="ar" Path="Text" Data="معمل بيطري: [?VetLabCode]"'}
    @{Old='Culture="ar" Path="Text" Data="??????: [?Place]"'; New='Culture="ar" Path="Text" Data="الموقع: [?Place]"'}
    @{Old='Culture="ar" Path="Text" Data="?????? ??????: [?SubPlace]"'; New='Culture="ar" Path="Text" Data="الفرع الفرعي: [?SubPlace]"'}
    @{Old='Culture="ar" Path="Text" Data="????? ???? ?????? : [ReortLabRef]"'; New='Culture="ar" Path="Text" Data="رقم المرجع المختبري : [ReortLabRef]"'}
    @{Old='Culture="ar" Path="Text" Data="??? ??????: [?SampleType]"'; New='Culture="ar" Path="Text" Data="نوع العينة: [?SampleType]"'}
)
Fix-File "SR_VL_StaffWaterHyg\SR_VL_StaffWaterHyg.repx" $staff

Write-Host "`nAll 6 files processed!"