-- ==========================
-- yesNoUnknown
-- ==========================
DECLARE @yesNoUnknownId UNIQUEIDENTIFIER = 'f19e2830-b2b5-4fba-8ce2-84aba4bc931b';
INSERT INTO lookupCategories(Id, Name) VALUES (@yesNoUnknownId, 'yesNoUnknown');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('28fe79ef-ab14-4c42-93fc-b702e62df2c3', @yesNoUnknownId, 'Yes'),
  ('fb67bc81-3361-48b1-8b0d-62b9c79c719b', @yesNoUnknownId, 'No'),
  ('8a273483-3444-4505-b7ce-8748b012ccf3', @yesNoUnknownId, 'Unknown');

-- ==========================
-- yesNoNaUnknown
-- ==========================
DECLARE @yesNoNaUnknownId UNIQUEIDENTIFIER = 'ab149262-20a6-44f2-9017-c171c930cb42';
INSERT INTO lookupCategories(Id, Name) VALUES (@yesNoNaUnknownId, 'yesNoNaUnknown');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('a4850aa7-4003-457c-a98e-2243d3ee30d3', @yesNoNaUnknownId, 'Yes'),
  ('d45288d5-70bc-48c0-9416-e835774d2651', @yesNoNaUnknownId, 'No'),
  ('437bd52c-06ed-405a-8451-c84efed84f38', @yesNoNaUnknownId, 'N/A'),
  ('a403a0d0-e588-4d1a-b1af-05fb284e934a', @yesNoNaUnknownId, 'Unknown');

-- ==========================
-- locationOptions
-- ==========================
DECLARE @locationOptionsId UNIQUEIDENTIFIER = 'b765fa18-ceec-4cfc-a927-91fb886c004e';
INSERT INTO lookupCategories(Id, Name) VALUES (@locationOptionsId, 'locationOptions');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('a7b36aeb-1405-42c8-917b-cc14d280cbd4', @locationOptionsId, 'CMJAH'),
  ('4b60056d-b423-40d2-9834-28040249fe99', @locationOptionsId, 'Other Hospital'),
  ('b8b1ddff-6455-4c10-b70b-e10d27136924', @locationOptionsId, 'Both');

-- ==========================
-- sepsisSites
-- ==========================
DECLARE @sepsisSitesId UNIQUEIDENTIFIER = '8ba19a0c-270b-4c0a-add2-003507965164';
INSERT INTO lookupCategories(Id, Name) VALUES (@sepsisSitesId, 'sepsisSites');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('fe9a0cf4-683d-4942-afa5-eec2e875f671', @sepsisSitesId, 'Blood'),
  ('442559f8-aaa3-48ca-8576-24981af2d94d', @sepsisSitesId, 'Urine'),
  ('87a05e09-e464-43de-9b6b-9519c84938c1', @sepsisSitesId, 'Skin'),
  ('09b97a3e-cb72-4cce-b6e8-da2aa7a3c555', @sepsisSitesId, 'Wound'),
  ('8a244db6-45bd-44c1-873c-0e98cffedc2c', @sepsisSitesId, 'Eye'),
  ('e2c49b2b-5ee6-4089-bfb6-823470203859', @sepsisSitesId, 'Meningitis'),
  ('b4d9710c-4b9c-4401-b79b-834df77430d2', @sepsisSitesId, 'Arthritis'),
  ('223eb837-5b61-46ab-9785-980f4573ead7', @sepsisSitesId, 'Pneumonia'),
  ('dd6eca59-901a-4cb1-9ab4-820f80de9826', @sepsisSitesId, 'Endocarditis');

-- ==========================
-- fungalLocationOptions
-- ==========================
DECLARE @fungalLocationOptionsId UNIQUEIDENTIFIER = '6a857e17-800b-4861-85b1-fb52b856b57f';
INSERT INTO lookupCategories (Id, Name) VALUES (@fungalLocationOptionsId, 'fungalLocationOptions');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('585aa872-8cd8-449d-a6e3-fe8bdae8224f', @fungalLocationOptionsId, 'Base hospital'),
  ('f9fb0fc7-e812-46ff-9467-9967b1f17d32', @fungalLocationOptionsId, 'Other hospital'),
  ('a385aab9-e61d-4359-aba2-c2b2ef651ca5', @fungalLocationOptionsId, 'Both');

-- ==========================
-- respDiagnosisOptions
-- ==========================
DECLARE @respDiagnosisOptionsId UNIQUEIDENTIFIER = 'b578f275-5aa0-4526-87dd-273f34276340';
INSERT INTO lookupCategories (Id, Name) VALUES (@respDiagnosisOptionsId, 'respDiagnosisOptions');

INSERT INTO lookupItems(Id, CategoryId, Name) VALUES
  ('9362bc35-ff29-4450-a4ee-b7bd0715498b', @respDiagnosisOptionsId, 'Transient tachypnoea of the newborn'),
  ('baf5102f-8238-4bb2-a0bc-7aa03060b71e', @respDiagnosisOptionsId, 'Congenital pneumonia'),
  ('b6f7e937-a22c-4809-8bd0-b93149ca0a01', @respDiagnosisOptionsId, 'Meconium aspiration syndrome'),
  ('453b7361-11a6-4515-b025-475092800517', @respDiagnosisOptionsId, 'Birth asphyxia'),
  ('95617055-75dc-42a9-96b4-f123421ad24b', @respDiagnosisOptionsId, 'Pneumothorax'),
  ('e32e7517-c539-4b09-801d-18c6c3231edb', @respDiagnosisOptionsId, 'Acquired pneumonia'),
  ('94ca3656-5ceb-45a0-b110-d1d2c5c4f63d', @respDiagnosisOptionsId, 'Pulmonary haemorrhage'),
  ('87d70317-e19e-4f5f-87d0-fdd4133bc8a5', @respDiagnosisOptionsId, 'PPHN'),
  ('19220c80-5977-47d7-88e5-3cfdf8b07b29', @respDiagnosisOptionsId, 'Atelectasis'),
  ('3a9ef15f-c16e-4a34-994c-4aa16eb76445', @respDiagnosisOptionsId, 'HMD/RDS'),
  ('896209d1-856b-4a75-ac23-818d9512742b', @respDiagnosisOptionsId, 'BPD/CLD');

-- ==========================
-- respSupportOptions
-- ==========================
DECLARE @respSupportOptionsId UNIQUEIDENTIFIER = 'cc65c352-bd6a-4c56-8267-ed28483ea2af';
INSERT INTO lookupCategories (Id, Name) VALUES (@respSupportOptionsId, 'respSupportOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('6e480658-867b-48d4-9c57-a460467a9d29', @respSupportOptionsId, 'Oxygen'),
  ('c1c3eb84-c26d-4f72-856b-c87a9ec8e908', @respSupportOptionsId, 'NCPAP'),
  ('87b830aa-4a9c-4540-83c2-51d746140c6c', @respSupportOptionsId, 'Conventional ventilation'),
  ('abfeb280-92a7-4f2d-94d1-0ecea2435f0f', @respSupportOptionsId, 'High frequency ventilation'),
  ('056db736-5990-4173-b76d-f3995815e1fa', @respSupportOptionsId, 'Nasal IMV/SIMV'),
  ('afa3e471-9e48-41fa-97b7-4ce24c2135d8', @respSupportOptionsId, 'High flow cannula'),
  ('92885058-998a-4d30-9e60-d2589fd7e591', @respSupportOptionsId, 'Unknown');

-- ==========================
-- ivhGrades
-- ==========================
DECLARE @ivhGradesId UNIQUEIDENTIFIER = 'cbcfaf60-f19e-43c6-8ba4-c997046e1e8f';
INSERT INTO lookupCategories (Id, Name) VALUES (@ivhGradesId, 'ivhGrades');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('96afe429-132b-4be1-9183-6b2731848f50', @ivhGradesId, 'None'),
  ('f5af7ca2-42c8-4c94-bae4-f9c9b96d238f', @ivhGradesId, '1'),
  ('2f86d23e-9ea5-424c-90be-6bfcdaa1d8bb', @ivhGradesId, '2'),
  ('b56dea63-250e-4ecc-9b58-20c959f1d110', @ivhGradesId, '3'),
  ('d503acf6-4f08-4418-b1c7-607cac234b2e', @ivhGradesId, '4');

-- ==========================
-- eosRecOptions
-- ==========================
DECLARE @eosRecOptionsId UNIQUEIDENTIFIER = '2e353620-eec4-4642-86f3-696b74de0f6f';
INSERT INTO lookupCategories (Id, Name) VALUES (@eosRecOptionsId, 'eosRecOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('79a99e60-ac3e-4628-9589-3eddbef8b71d', @eosRecOptionsId, 'No culture, No Antibiotics'),
  ('4d21fada-b3a6-40bf-a739-28896494e968', @eosRecOptionsId, 'Strong Consider Empiric Antibiotics'),
  ('68aae1f4-0fce-47cd-9719-ee98ebc3cc4b', @eosRecOptionsId, 'Blood Culture'),
  ('a8f173b3-6f66-4d49-8b2b-d726cb9ceb64', @eosRecOptionsId, 'Empiric Antibiotics');

-- ==========================
-- hieGradeOptions
-- ==========================
DECLARE @hieGradeOptionsId UNIQUEIDENTIFIER = 'e2fd4415-7a70-4de2-9f9a-c66d980d36b3';
INSERT INTO lookupCategories (Id, Name) VALUES (@hieGradeOptionsId, 'hieGradeOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('af8147e1-320c-4340-bb67-8889234510a1', @hieGradeOptionsId, '1'),
  ('970a9f01-74bc-46ef-8d58-f02c9fe82e7a', @hieGradeOptionsId, '2'),
  ('cb3bea36-6703-4960-9b05-f436ca85d844', @hieGradeOptionsId, '3');

-- ==========================
-- aeeGReasonOptions
-- ==========================
DECLARE @aeeGReasonOptionsId UNIQUEIDENTIFIER = '49ae6a35-8ccb-43a2-990f-d4189b033728';
INSERT INTO lookupCategories (Id, Name) VALUES (@aeeGReasonOptionsId, 'aeeGReasonOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('fe2f1171-f7f0-4f53-a8ed-da2b1dfc64d8', @aeeGReasonOptionsId, 'Machine unavailable'),
  ('2fb54030-952f-43f3-b78f-6356bb42175d', @aeeGReasonOptionsId, 'Patient unstable'),
  ('b21d19f5-35f5-4c7d-bb03-82ce2a7ca7dc', @aeeGReasonOptionsId, 'Parental refusal'),
  ('4801a13a-fad9-418d-9824-845de9ab1eec', @aeeGReasonOptionsId, 'Other');

-- ==========================
-- coolingReasonOptions
-- ==========================
DECLARE @coolingReasonOptionsId UNIQUEIDENTIFIER = '5abe4055-fe8b-40fc-be50-06a866cf818d';
INSERT INTO lookupCategories (Id, Name) VALUES (@coolingReasonOptionsId, 'coolingReasonOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('47ac7f2c-ba0c-494d-a879-53693eb5f8e4', @coolingReasonOptionsId, 'Not indicated'),
  ('dd74463e-5315-4d14-b252-5b1439ffe079', @coolingReasonOptionsId, 'Medical contraindication'),
  ('4b95fc08-9477-4a18-8112-68d816160042', @coolingReasonOptionsId, 'Equipment failure'),
  ('7721d02d-801a-4215-958c-dc1feabd53fb', @coolingReasonOptionsId, 'Parental refusal'),
  ('7b11fbd9-5af0-4344-9736-1b0bf3217fe5', @coolingReasonOptionsId, 'Other');

-- ==========================
-- coolingTypeOptions
-- ==========================
DECLARE @coolingTypeOptionsId UNIQUEIDENTIFIER = 'd3b98292-a3cc-4205-bda1-34b38be670da';
INSERT INTO lookupCategories (Id, Name) VALUES (@coolingTypeOptionsId, 'coolingTypeOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('2b6e5a02-fcf3-40d3-a9a7-9fa8f99b8153', @coolingTypeOptionsId, 'Whole‑body cooling'),
  ('db89e640-23cf-4c02-a249-c234dea1ffa2', @coolingTypeOptionsId, 'Selective head cooling'),
  ('a61c8dab-fd2f-4587-83c4-529d6b0be15e', @coolingTypeOptionsId, 'Other');

-- ==========================
-- necSurgeryTypeOptions
-- ==========================
DECLARE @necSurgeryTypeOptionsId UNIQUEIDENTIFIER = 'b037c865-ae2c-4898-b941-1c543426a789';
INSERT INTO lookupCategories (Id, Name) VALUES (@necSurgeryTypeOptionsId, 'necSurgeryTypeOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('e1dc1be6-993e-41bc-bd46-351d471d8417', @necSurgeryTypeOptionsId, 'Resection'),
  ('b6196811-c1de-4a29-bba0-35bc3cc2d38e', @necSurgeryTypeOptionsId, 'Stoma formation'),
  ('7d521045-e9c1-4a02-bca2-3db204766fd1', @necSurgeryTypeOptionsId, 'Peritoneal drainage'),
  ('aeff3c45-74af-4e34-a98d-c2158cc86e7e', @necSurgeryTypeOptionsId, 'Other');

-- ==========================
-- ropFindingsOptions
-- ==========================
DECLARE @ropFindingsOptionsId UNIQUEIDENTIFIER = 'c0322c49-c606-4e23-b3e5-ad858ea6efd1';
INSERT INTO lookupCategories (Id, Name) VALUES (@ropFindingsOptionsId, 'ropFindingsOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('3a575424-3839-4125-86b1-f48f2428fdfc', @ropFindingsOptionsId, 'Stage 1'),
  ('f1f34692-fd58-4454-959f-e40e0fcfce50', @ropFindingsOptionsId, 'Stage 2'),
  ('de908855-7e23-4670-80fa-131268d75a3c', @ropFindingsOptionsId, 'Stage 3'),
  ('1ca70841-f7e5-43bc-9816-674633b56320', @ropFindingsOptionsId, 'Plus disease'),
  ('69e328e0-2efa-4a23-9475-8a38522ad79f', @ropFindingsOptionsId, 'Other');

-- ==========================
-- kmcTypeOptions
-- ==========================
DECLARE @kmcTypeOptionsId UNIQUEIDENTIFIER = 'b049a713-5556-4bfa-86f5-d66dadf6ec98';
INSERT INTO lookupCategories (Id, Name) VALUES (@kmcTypeOptionsId, 'kmcTypeOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('fd886985-1df9-4645-a572-da6611188352', @kmcTypeOptionsId, 'Skin‑to‑skin contact'),
  ('a7f8ba3f-6221-4607-86d5-feca76f7a6b4', @kmcTypeOptionsId, 'Breastfeeding support'),
  ('a8e58caa-d28b-4ff3-a8c3-5b215300bb88', @kmcTypeOptionsId, 'Thermal regulation'),
  ('c3753db9-45be-42d2-a139-0194958fd68d', @kmcTypeOptionsId, 'Parent education'),
  ('4105c9c3-3743-49e8-b4e2-4eecb83798ed', @kmcTypeOptionsId, 'Other');

-- ==========================
-- ropSurgeryOptions
-- ==========================
DECLARE @ropSurgeryOptionsId UNIQUEIDENTIFIER = 'b9117427-e94c-4e72-994b-47ed4d035332';
INSERT INTO lookupCategories (Id, Name) VALUES (@ropSurgeryOptionsId, 'ropSurgeryOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('2be196c8-fc50-4319-ae20-4b6b3a1b2543', @ropSurgeryOptionsId, 'Laser therapy'),
  ('e0b43700-f1bc-4b17-9bba-f46478131b9f', @ropSurgeryOptionsId, 'Anti‑VEGF injection'),
  ('1c4d82e7-ec8c-4ad0-9337-42c9cbd43a34', @ropSurgeryOptionsId, 'Vitrectomy'),
  ('98a66940-0995-4e75-a0ad-4d30cdf253db', @ropSurgeryOptionsId, 'Other');

-- ==========================
-- metabolicOptions
-- ==========================
DECLARE @metabolicOptionsId UNIQUEIDENTIFIER = '7a6de903-2377-4c8b-9072-a6036e027b74';
INSERT INTO lookupCategories (Id, Name) VALUES (@metabolicOptionsId, 'metabolicOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('9ee67180-bcb7-462f-a874-240122edf5dd', @metabolicOptionsId, 'Hypoglycemia'),
  ('6d6cf93f-76fb-447a-aadf-2d0e35cbe396', @metabolicOptionsId, 'Hyperglycemia'),
  ('79efb12c-8c0d-4aeb-806f-324a706082d6', @metabolicOptionsId, 'Electrolyte imbalance');

-- ==========================
-- glucoseAbnOptions
-- ==========================
DECLARE @glucoseAbnOptionsId UNIQUEIDENTIFIER = '85f2c828-0bab-4777-8bbb-f1431770fd7c';
INSERT INTO lookupCategories (Id, Name) VALUES (@glucoseAbnOptionsId, 'glucoseAbnOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('2c702392-6af6-4c90-be87-c425b7b07c3c', @glucoseAbnOptionsId, 'Hypoglycemia'),
  ('53f53ad0-8232-4856-a13d-cc31022e0cc6', @glucoseAbnOptionsId, 'Hyperglycemia');

-- ==========================
-- outcomeOptions
-- ==========================
DECLARE @outcomeOptionsId UNIQUEIDENTIFIER = '0e50994e-5eee-42fd-9798-c8fa9b313225';
INSERT INTO lookupCategories (Id, Name) VALUES (@outcomeOptionsId, 'outcomeOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('69f903e3-d45f-4b29-b7cd-0db902e8fefb', @outcomeOptionsId, 'Home'),
  ('a854fcb3-6fe3-407f-bb8b-3f2a956eff01', @outcomeOptionsId, 'Transfer to hospital'),
  ('35eb2fa2-3636-455f-b3bc-fc938886a9bc', @outcomeOptionsId, 'Death');

-- ==========================
-- feedOptions
-- ==========================
DECLARE @feedOptionsId UNIQUEIDENTIFIER = '113a235a-c203-46f7-b93a-f75f1c2f8a66';
INSERT INTO lookupCategories (Id, Name) VALUES (@feedOptionsId, 'feedOptions');

INSERT INTO LookupItems (Id, CategoryId, Name) VALUES
  ('bc80a32c-05e1-41b3-80e5-1d73c727d7a9', @feedOptionsId, 'Breast milk'),
  ('1058bd80-819e-409f-b2c2-ea9e79546733', @feedOptionsId, 'Formula'),
  ('a45ec4f6-973d-4091-b3cb-5a3db0afe3e2', @feedOptionsId, 'Breastmilk and formula');
