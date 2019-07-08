import { Data } from './Data';

export class Forecast {
    city_name: string;
    state_code: string;
    country_code: string;
    lat: string;
    lon: string;
    timezone: string;
    data: Data[]
}
