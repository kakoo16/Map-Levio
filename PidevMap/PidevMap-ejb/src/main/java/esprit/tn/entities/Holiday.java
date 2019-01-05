package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


/**
 * The persistent class for the Holidays database table.
 * 
 */
@Entity
@Table(name="Holidays")
@NamedQuery(name="Holiday.findAll", query="SELECT h FROM Holiday h")
public class Holiday implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="HolidayId")
	private int holidayId;

	@Column(name="Description")
	private String description;

	private Timestamp end_Date;

	private Timestamp stard_Date;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="Ressource_Id")
	private AspNetUser aspNetUser;

	//bi-directional many-to-one association to RessourceN
	@ManyToOne
	@JoinColumn(name="RessourceN_RessourceId")
	private RessourceN ressourceN;

	public Holiday() {
	}

	public int getHolidayId() {
		return this.holidayId;
	}

	public void setHolidayId(int holidayId) {
		this.holidayId = holidayId;
	}

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public Timestamp getEnd_Date() {
		return this.end_Date;
	}

	public void setEnd_Date(Timestamp end_Date) {
		this.end_Date = end_Date;
	}

	public Timestamp getStard_Date() {
		return this.stard_Date;
	}

	public void setStard_Date(Timestamp stard_Date) {
		this.stard_Date = stard_Date;
	}

	public AspNetUser getAspNetUser() {
		return this.aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

	public RessourceN getRessourceN() {
		return this.ressourceN;
	}

	public void setRessourceN(RessourceN ressourceN) {
		this.ressourceN = ressourceN;
	}

}