/*
 Navicat Premium Data Transfer

 Source Server         : Postgres
 Source Server Type    : PostgreSQL
 Source Server Version : 160001 (160001)
 Source Host           : localhost:5432
 Source Catalog        : place
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 160001 (160001)
 File Encoding         : 65001

 Date: 22/01/2024 02:49:26
*/


-- ----------------------------
-- Table structure for lokasi_peserta
-- ----------------------------
DROP TABLE IF EXISTS "public"."lokasi_peserta";
CREATE TABLE "public"."lokasi_peserta" (
  "id" int4 NOT NULL DEFAULT nextval('lokasi_peserta_id_seq'::regclass),
  "ownername" varchar(100) COLLATE "pg_catalog"."default",
  "placename" varchar(100) COLLATE "pg_catalog"."default",
  "address" varchar(255) COLLATE "pg_catalog"."default",
  "placestype" varchar(255) COLLATE "pg_catalog"."default",
  "date" date
)
;

-- ----------------------------
-- Records of lokasi_peserta
-- ----------------------------
INSERT INTO "public"."lokasi_peserta" VALUES (1, 'ibnu', 'cipayung', NULL, NULL, NULL);
INSERT INTO "public"."lokasi_peserta" VALUES (2, 'citra', 'jakarta', NULL, NULL, NULL);

-- ----------------------------
-- Primary Key structure for table lokasi_peserta
-- ----------------------------
ALTER TABLE "public"."lokasi_peserta" ADD CONSTRAINT "lokasi_peserta_pkey" PRIMARY KEY ("id");
