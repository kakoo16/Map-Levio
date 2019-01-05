package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;

/**
 * The primary key class for the Mandates database table.
 * 
 */
@Embeddable
public class MandatePK implements Serializable {
	//default serial version id, required for serializable classes.
	private static final long serialVersionUID = 1L;

	@Column(name="ProjectId", insertable=false, updatable=false)
	private int projectId;

	@Column(name="Id", insertable=false, updatable=false)
	private String id;

	@Temporal(TemporalType.TIMESTAMP)
	private java.util.Date start_Date;

	@Temporal(TemporalType.TIMESTAMP)
	private java.util.Date end_Date;

	public MandatePK() {
	}
	public int getProjectId() {
		return this.projectId;
	}
	public void setProjectId(int projectId) {
		this.projectId = projectId;
	}
	public String getId() {
		return this.id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public java.util.Date getStart_Date() {
		return this.start_Date;
	}
	public void setStart_Date(java.util.Date start_Date) {
		this.start_Date = start_Date;
	}
	public java.util.Date getEnd_Date() {
		return this.end_Date;
	}
	public void setEnd_Date(java.util.Date end_Date) {
		this.end_Date = end_Date;
	}

	public boolean equals(Object other) {
		if (this == other) {
			return true;
		}
		if (!(other instanceof MandatePK)) {
			return false;
		}
		MandatePK castOther = (MandatePK)other;
		return 
			(this.projectId == castOther.projectId)
			&& this.id.equals(castOther.id)
			&& this.start_Date.equals(castOther.start_Date)
			&& this.end_Date.equals(castOther.end_Date);
	}

	public int hashCode() {
		final int prime = 31;
		int hash = 17;
		hash = hash * prime + this.projectId;
		hash = hash * prime + this.id.hashCode();
		hash = hash * prime + this.start_Date.hashCode();
		hash = hash * prime + this.end_Date.hashCode();
		
		return hash;
	}
}