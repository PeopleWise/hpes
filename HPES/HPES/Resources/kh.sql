//为军服务补贴sum(cost)*0.8
select sum(cost)*0.8,sum(charge) from (select sum(decode(TOTAL_COSTS,null,0,TOTAL_COSTS)) cost,sum(decode(TOTAL_COSTS,null,0,TOTAL_CHARGES)) charge from outp_rcpt_master where VISIT_DATE>=to_date('20130801','yyyymmdd') and  VISIT_DATE< to_date('20130901','yyyymmdd') and CHARGE_TYPE='军队医改'
union all
select  sum(decode(COSTS,null,0,COSTS)) cost,sum(decode(CHARGES,null,0,CHARGES)) charge from pat_visit a,inp_bill_detail b  where a.patient_id=b.patient_id and a.visit_id=b.visit_id and BILLING_DATE_TIME>=to_date('20130801','yyyymmdd') and  BILLING_DATE_TIME< to_date('20130901','yyyymmdd') and CHARGE_TYPE='军队医改');
//药占比
select sum(cost),sum(yp),sum(yp)/sum(cost) from (select sum(decode(CHARGES,null,0,CHARGES)) cost,sum(decode(ITEM_CLASS,'A',CHARGES,0)) yp from outp_rcpt_master a,outp_bill_items b where a.rcpt_no=b.rcpt_no and a.VISIT_DATE>=to_date('20130801','yyyymmdd') and  a.VISIT_DATE< to_date('20130901','yyyymmdd')
union all
select  sum(decode(CHARGES,null,0,CHARGES)) cost,sum(decode(ITEM_CLASS,'A',CHARGES,0))  yp  from inp_bill_detail where  BILLING_DATE_TIME>=to_date('20130801','yyyymmdd') and  BILLING_DATE_TIME< to_date('20130901','yyyymmdd') );

////日均占床；
select sum(decode(bed_used_num,null,0,bed_used_num)),count(distinct(st_date)),sum(decode(bed_used_num,null,0,bed_used_num))/count(distinct(st_date)) from dept_adt_day  where 
st_date>=to_date('20130101','yyyymmdd') and st_date<to_date('20130901','yyyymmdd');
////平均住院日
select sum(DISCHARGE_DATE_TIME-ADMISSION_DATE_TIME),count(*),sum(DISCHARGE_DATE_TIME-ADMISSION_DATE_TIME)/count(*)  from pat_visit where DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and
DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd');
////军队与地方前五病种
select c.diagnosis_code,c.diagnosis_name,count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd')
group by c.diagnosis_code,c.diagnosis_name order by count(*) desc;
////军队前5病种
select * from (select c.diagnosis_code,c.diagnosis_name,count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and charge_type='军队医改'
group by c.diagnosis_code,c.diagnosis_name order by count(*) desc) where   rownum<6;
////地方前5病种
select c.diagnosis_code,c.diagnosis_name,count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and charge_type<>'军队医改'
group by  c.diagnosis_code,c.diagnosis_name  order by count(*) desc;
////select * from diagnosis_dict;
////前5病种的平均费用
select sum(decode(a.total_costs,null,0,a.total_costs)),count(*),sum(decode(a.total_costs,null,0,a.total_costs))/count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and charge_type='军队医改' and b.DIAGNOSIS_CODE='I25.101';
//select sum(decode(a.total_costs,null,0,a.total_costs)),count(*),sum(decode(a.total_costs,null,0,a.total_costs))/count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c where 
//a.patient_id=b.patient_id and a.visit_id=b.visit_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE
//and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and charge_type<>'军队医改' and b.DIAGNOSIS_CODE='I25.101';

//select * from pat_visit where DISCHARGE_DATE_TIME>to_date('20130701','yyyymmdd') and charge_type='军队医改';
// 按年龄统计
//地方
select c.diagnosis_code,c.diagnosis_name,count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c,pat_master_index d where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and a.patient_id=d.patient_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE and (a.ADMISSION_DATE_TIME-d.DATE_OF_BIRTH)/365<20
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and a.charge_type<>'军队医改'
group by c.diagnosis_code,c.diagnosis_name order by count(*) desc;
//军队
select c.diagnosis_code,c.diagnosis_name,count(*) from pat_visit a,diagnostic_category b,diagnosis_dict c,pat_master_index d where 
a.patient_id=b.patient_id and a.visit_id=b.visit_id and a.patient_id=d.patient_id and b.DIAGNOSIS_TYPE='3' AND b.DIAGNOSIS_CODE=c.DIAGNOSIS_CODE and (a.ADMISSION_DATE_TIME-d.DATE_OF_BIRTH)/365<20
and DISCHARGE_DATE_TIME>=to_date('20110101','yyyymmdd') and DISCHARGE_DATE_TIME<to_date('20120101','yyyymmdd') and charge_type='军队医改'
group by c.diagnosis_code,c.diagnosis_name order by count(*) desc;
//药品集中采购率
select z_amount/s_amount from (select sum(PURCHASE_PRICE*QUANTITY) s_amount from drug_import_master a,drug_import_detail b where 
import_date>=to_date('20130101','yyyymmdd')  and 
import_date< to_date('20130106','yyyymmdd') and
a.document_no=b.document_no and
storage in ('7703','7710') and 
import_class in ('采购入库','') and
ACCOUNT_INDICATOR=1),
(select  sum(PURCHASE_PRICE*QUANTITY) z_amount  from drug_import_master a,drug_import_detail b,drug_dict c where 
import_date>=to_date('20130101','yyyymmdd')  and 
import_date< to_date('20130106','yyyymmdd') and
a.document_no=b.document_no and
storage in ('7703','7710') and 
import_class in ('采购入库','') and
ACCOUNT_INDICATOR=1 and
b.drug_code=c.drug_code and
b.drug_spec=c.drug_spec and
b.units=c.units);

//耗材集中采购率
select z_amount/s_amount from (select sum(PURCHASE_PRICE*QUANTITY) s_amount from mtrl_import_master a,mtrl_import_detail b where 
import_date>=to_date('20130101','yyyymmdd')  and 
import_date< to_date('20130106','yyyymmdd') and
a.document_no=b.document_no and
storage in ('8301','8302','8303') and 
import_class in ('采购入库','') and
ACCOUNT_INDICATOR=1),
(select  sum(PURCHASE_PRICE*QUANTITY) z_amount  from mtrl_import_master a,mtrl_import_detail b,mtrl_dict c where 
import_date>=to_date('20130101','yyyymmdd')  and 
import_date< to_date('20130106','yyyymmdd') and
a.document_no=b.document_no and
storage in ('8301','8302','8303') and 
import_class in ('采购入库','') and
ACCOUNT_INDICATOR=1 and
b.mtrl_code=c.mtrl_code and
b.mtrl_spec=c.mtrl_spec and
b.units=c.units);

//抗生素使用率
//按当月发生
select k,l,decode(l,null,0,l)/k from 
(
select sum(a.e) l
from 
(select patient_id a,visit_id b,count(*) d,1 e
from inp_bill_detail
where billing_date_time>=to_date('20130801','yyyymmdd')
  and billing_date_time<to_date('20130807','yyyymmdd')
and item_class='A'
and substr(item_code,1,2) in ('01','02','03')
and item_code not in ('01010015I0','01010017I0','01010041T0','01010113I0','01100001C0','01990001T0','02010001T0','02030002T0','02030003T0','02030004T0','02050002I0','02050002I0','02050005T0','02050011T0','02050013C0','02050016I0','02050017T0','02050018I0','01010109I0','02040022T0')
group by patient_id,visit_id) a
) 
,
(select sum(b.e) k
from 
(select count(*) d,1 e
from inp_bill_detail
where billing_date_time>=to_date('20130801','yyyymmdd')
  and billing_date_time<to_date('20130807','yyyymmdd')
group by patient_id,visit_id ) b
) ;
//按当月出院
select k,l,decode(l,null,0,l)/k from 
(
select sum(a.e) l
from 
(select h.patient_id a,h.visit_id b,count(*) d,1 e
from pat_visit h,inp_bill_detail i
where DISCHARGE_DATE_TIME>=to_date('20130801','yyyymmdd')
  and DISCHARGE_DATE_TIME<to_date('20130807','yyyymmdd')
and h.patient_id=i.patient_id
and h.visit_id=i.visit_id
and item_class='A'
and substr(item_code,1,2) in ('01','02','03')
and item_code not in ('01010015I0','01010017I0','01010041T0','01010113I0','01100001C0','01990001T0','02010001T0','02030002T0','02030003T0','02030004T0','02050002I0','02050002I0','02050005T0','02050011T0','02050013C0','02050016I0','02050017T0','02050018I0','01010109I0','02040022T0')
group by h.patient_id,h.visit_id) a
) 
,
(select sum(b.e) k
from 
(select count(*) d,1 e
from pat_visit
where DISCHARGE_DATE_TIME>=to_date('20130801','yyyymmdd')
  and DISCHARGE_DATE_TIME<to_date('20130807','yyyymmdd') 
group by patient_id,visit_id) b
) ;
