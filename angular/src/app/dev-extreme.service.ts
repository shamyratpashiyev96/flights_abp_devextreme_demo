import { PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { IdentityRoleService, IdentityUserService } from '@abp/ng.identity/proxy';
import { Injectable } from '@angular/core';
import { AirportService } from '@proxy/airports';
import { map, mapTo } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DevExtremeService {
  pagedRequestDto : any = new PagedAndSortedResultRequestDto();
  airports = this.service.getList(this.pagedRequestDto).pipe(map((result)=>result.items));

  constructor(private service: AirportService) { 

  }


}
