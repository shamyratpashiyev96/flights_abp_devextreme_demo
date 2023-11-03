import type { AuditedEntityDto } from '@abp/ng.core';

export interface AirportDto extends AuditedEntityDto<number> {
  city?: string;
  code?: string;
}

export interface CreateUpdateDto {
  city?: string;
  code?: string;
}
